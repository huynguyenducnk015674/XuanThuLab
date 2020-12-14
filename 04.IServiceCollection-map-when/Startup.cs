using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.IServiceCollection_map_when.impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _04.IServiceCollection_map_when
{
    public class Startup
    {
        IServiceCollection _services;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IListProductName, LaptopName>();
            services.AddTransient<PhoneName, PhoneName>();
            services.AddTransient<ProductController, ProductController>();
            this._services = services;
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
                
            });
            
        }
    }
}
