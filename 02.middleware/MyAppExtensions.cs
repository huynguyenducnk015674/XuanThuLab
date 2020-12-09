﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02.middleware
{
    public static class MyAppExtensions
    {
        public static IApplicationBuilder CheckAcessMiddleware(this IApplicationBuilder app)
        {
           return  app.UseMiddleware<CheckAcessMiddleware>();
        }
        public static IApplicationBuilder FrontMiddleWare(this IApplicationBuilder app)
        {
            return app.UseMiddleware<FrontMiddleWare>();
        }
    }
}
