using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _05._razor01.basic
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
            // Thêm các dịch vụ liên quan đến Razor Page
            services.AddRazorPages((option) =>
            {
                option.Conventions.AddPageRoute("/Privacy", "/chinh-sach.html");
                option.Conventions.AddAreaPageRoute("Product", "/Detail", "/sanpham/{nameproduct?}");
            });
          
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
            // Chuyển hướng https
            app.UseHttpsRedirection();
            // Kích hoạt truy cập file tĩnh (file trong wwwroot)
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Thêm endpoint chuyển đến các trang Razor Page
                // trong thư mục Pages
                endpoints.MapRazorPages();
            });
        }
    }
}
