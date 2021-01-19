using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace _02.middleware
{
    public class FrontMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine(context.Request.Path);
            context.Items.Add("MainCode", "SG0132");
            await next(context);
        }
    }
}
