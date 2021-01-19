using _09.Album.Data;
using _09.Album.Mail;
using _09.Album.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace _09.Album
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            var mailSettings = Configuration.GetSection("MailSettings");// đọc config
            services.Configure<MailSettings>(mailSettings); // đăng ký để Inject
            services.AddTransient<IEmailSender, SendMailService>();// Kích hoạt Options
                                                                   // Đăng ký Identity
                                                                   //Đăng ký dịch vụ Identity vào hệ thống
                                                                   // Đăng ký AppDbContext
            services.AddDbContext<AppDbContext>(option =>
            {
                string connectionString = Configuration.GetConnectionString("AppDbContext");
                option.UseSqlServer(connectionString);
            });

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            // ReConfig Identity (Custom config identity)
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false; // Không bắt phải có số
                options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
                options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
                options.Password.RequireUppercase = false; // Không bắt buộc chữ in
                options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
                options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt
                                                          // Cấu hình Lockout - khóa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
                options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
                options.Lockout.AllowedForNewUsers = true;
                options.SignIn.RequireConfirmedAccount = true;
                // Cấu hình về User.
                options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email là duy nhất

                // Cấu hình đăng nhập.
                options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại
              
            });

            services.AddAuthentication()
                  .AddGoogle(googleOption =>
                  {
                      // Đọc thông tin Authentication:Google từ appsettings.json
                      IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");
                      googleOption.ClientId = googleAuthNSection["ClientId"];
                      googleOption.ClientSecret = googleAuthNSection["ClientSecret"];
                  })
                  .AddFacebook(facebookOptions =>
                  {
                      // Đọc cấu hình
                      IConfigurationSection facebookAuthNSection = Configuration.GetSection("Authentication:Facebook");
                      facebookOptions.AppId = facebookAuthNSection["AppId"];
                      facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
                      // Thiết lập đường dẫn Facebook chuyển hướng đến
                      facebookOptions.CallbackPath = "/dang-nhap-tu-facebook";
                  });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/login/";
                options.LogoutPath = $"/logout/";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
                
            });
            services.AddTransient<IAuthorizationHandler, MinimumAgeHandler>();
            services.AddTransient<IAuthorizationHandler, CanUpdatePostAgeHandler>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminDropdown", policy =>
                {
                    policy.RequireClaim("permission", "manage.user");
                });
                options.AddPolicy("MyPolicy2", policty =>
                {
                    policty.Requirements.Add(new MinimumAgeRequirement(10));
                });
            });
         
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
