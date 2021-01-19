using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _03.map_request_response
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    string menu = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string content = HtmlHelper.HtmlTrangchu();
                    string html = HtmlHelper.HtmlDocument("Home Page", menu + content);
                    await context.Response.WriteAsync(html);
                });
                endpoints.Map("/RequestInfo/abc/xyz", async context =>
                {
                    string menu = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string requestInfo = RequestProcess.RequestInfo(context.Request).HtmlTag("div", "container");
                    string html = HtmlHelper.HtmlDocument("Thông tin Request", menu + requestInfo);
                    await context.Response.WriteAsync(html);
                });
                endpoints.MapGet("/Encoding", async context =>
                {
                    await context.Response.WriteAsync("Endcoding");
                });
                endpoints.MapGet("/Cookies", async context =>
                {
                    await context.Response.WriteAsync("Cookies");
                });
            });
            app.Map("/Json", (app) =>
            {
                app.Run(async context =>
              {
                  await context.Response.WriteAsync(RequestProcess.PrintJson(context.Request).Result);
              });
            });
            app.Map("/Form", (app) =>
             {
                 app.Run(async context =>
                {
                    string menu = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    string formhtml = await RequestProcess.FormProcess(context.Request);
                    formhtml = formhtml.HtmlTag("div", "container");
                    string html = HtmlHelper.HtmlDocument("Form Post", (menu + formhtml));
                    await context.Response.WriteAsync(html);

                });
             });
        }
    }
}
