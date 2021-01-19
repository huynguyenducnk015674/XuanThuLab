using _04.IServiceCollection_map_when.impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Text;

namespace _04.IServiceCollection_map_when
{
    public class Startup
    {
        IServiceCollection _services;
        IConfiguration _config;
        public Startup(IConfiguration _config)
        {
            this._config = _config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IListProductName, LaptopName>();
            services.AddTransient<PhoneName, PhoneName>();
            services.AddTransient<ProductController, ProductController>();
            services.AddOptions();
            this._services = services;
            services.Configure<TestOptions>(_config.GetSection("TestOptions"));

            services.AddDistributedMemoryCache();
            services.AddSession(opt =>
            {
                opt.Cookie.Name = "xuanthulab";
                opt.IdleTimeout = new TimeSpan(0, 60, 0);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(
                        HtmlHelper.HtmlDocument("HomePage", HtmlHelper.MenuTop(
                            new object[]
                            {
                                new { url="/home",label="Home" },
                                new { url="/product",label="product"}
                            }
                            , context.Request))
                        );
                });
                endpoints.MapGet("/product", async context =>
                 {
                     var productController = app.ApplicationServices.GetService<ProductController>();
                     await productController.List(context);
                 });
                endpoints.MapGet("/RequestInfo", async context =>
                 {

                     await context.Response.WriteAsync(ProductController.CountAccessInfo(context));
                 });
                app.MapWhen(
                    (context) =>
                    {
                        return context.Request.Path.Value.StartsWith("/abcxyz");
                    },
                    (appBuilder) =>
                    {
                        appBuilder.Run(
                           async (context) =>
                            {
                                await appBuilder.ApplicationServices.GetService<ProductController>().List(context);
                            }
                                );
                    }

                    );
                app.Map("/allservice", (app01) =>
                {
                    app01.Run(async (context) =>
                    {
                        var stringBuilder = new StringBuilder();
                        stringBuilder.Append($"{"Tên".HtmlTag("th")}{"LifeTime".HtmlTag("th")}{"Tên đầy đủ".HtmlTag("th")}".HtmlTag("tr"));
                        _services.ToList()
                        .ForEach(service =>
                        {
                            string str = $"{service.ServiceType.Name.HtmlTag("td")}" +
                            $"{service.Lifetime.ToString().HtmlTag("td")}" +
                            $"{service.ServiceType.FullName.HtmlTag("td")}";
                            stringBuilder.Append(str.HtmlTag("tr"));
                        });
                        string htmlAllService = stringBuilder.ToString().HtmlTag("table", "table table-bordered table-sm");
                        await context.Response.WriteAsync(HtmlHelper.HtmlDocument("All Service", htmlAllService));
                    });


                });
                app.Map("/showoption", (appOption) =>
                {
                    appOption.Run(async (context) =>
                    {
                        IConfiguration config = appOption.ApplicationServices.GetService<IConfiguration>();
                        var testopt = config.GetSection("TestOptions").Get<TestOptions>();
                        await context.Response.WriteAsync(testopt.opt_key2.K1);
                    });
                });


            });

        }
    }
}
