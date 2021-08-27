using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldWebApp
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;

        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async System.Threading.Tasks.Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h1> Hello from Simple Middleware </h1> </div>");
            await _next(context);
            await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h1> Bye from Simple Middleware </h1> </div>");
        }
    }
}
