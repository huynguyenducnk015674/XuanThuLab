using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(_09.Album.Areas.Identity.IdentityHostingStartup))]
namespace _09.Album.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                //services.AddDbContext<AppDbContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("AppDbContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}