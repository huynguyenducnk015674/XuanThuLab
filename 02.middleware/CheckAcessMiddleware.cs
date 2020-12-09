using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02.middleware
{
    public class CheckAcessMiddleware
    {
        private RequestDelegate _next;
        public CheckAcessMiddleware(RequestDelegate _next) => this._next = _next;
        public async Task Invoke(HttpContext httpContext)
        {
            if(httpContext.Request.Path=="/testxxx")
            {
                Console.WriteLine("CheckAccessMiddleWare : Cấm không cho truy cập");
                await Task.Run( async () =>
                {
                    string html = "<h1>CAM KHONG DUOC TRUY CAP</h1>";
                    httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                    await httpContext.Response.WriteAsync(html);
                });
            }
            else
            {
                httpContext.Response.Headers.Add("throughCheckAcessMiddleware", DateTime.Now.ToString());
                Console.WriteLine($"CheckAcessMiddleware: Cho truy cập :{httpContext.Items["MainCode"]} ");

                // Chuyển Middleware tiếp theo trong pipeline
                await _next(httpContext);
            }
            

        }
    }
}
