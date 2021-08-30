using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            /*
            * AddMvc:
            * We can create MVC app and also API using AddMvc
            */
            services.AddMvc();

            /*
            * AddControllers:
            * We cannot render pages when we use AddController it can be used for building api
            */
            //services.AddControllers();

            /*
            * AddControllersWithViews:
            * We can create MVC app and also API using AddMvc but does not support Razor Pages
            */
            services.AddControllersWithViews();

            /*
            * AddRazorPages:
            * We can create MVC app using AddRazorPages but does not 
            */
            //services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions()
                {
                    SourceCodeLineCount = 1
                };
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }


            //ADD BEFORE OTHER MIDDLEWARES
            app.UseStaticFiles();

            //app.UseMiddleware<SimpleMiddleware>();


            #region Assignment_Start

            //TRY 1
            //Request incoming to middleware 1
            //Request incoming to middleware 2
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 2 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 2 \n");
            //});


            ////TRY 2
            ////Request incoming to middleware 1
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 2 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 2 \n");
            //});


            ////TRY 3
            ////Request incoming to middleware 1 
            ////Request incoming to middleware 2
            ////Request outcoming to middleware 2
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 2 \n");
            //    await context.Response.WriteAsync("Request outcoming to middleware 2 \n");
            //});


            //////TRY 4
            ////Request incoming to middleware 1
            ////Request incoming to Terminating middleware
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to Terminating middleware\n");
            //});

            ////TRY 5
            ////Request incoming to middleware 1
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to Terminating middleware\n");
            //});

            ////TRY 6
            ////Request incoming to middleware 1
            ////Request incoming to Terminating middleware
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to Terminating middleware\n");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });

            //    endpoints.MapGet("/hello", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello from /hello endpoints");
            //     });
            //});


            //TRY 7
            //Request incoming to middleware 1
            //Request incoming to middleware 2
            //Hello World!
            //Request outcoming to middleware 2
            //Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 2 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 2 \n");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!\n");
            //    });

            //    endpoints.MapGet("/hello", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from /hello endpoints\n");
            //    });
            //});


            ////TRY 8
            ////NOTE: REQUEST TO /hello ENDPOINT
            ////Request incoming to middleware 1
            ////Request incoming to middleware 2
            ////Hello from / hello endpoints
            //// Request outcoming to middleware 2
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 2 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 2 \n");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!\n");
            //    });

            //    endpoints.MapGet("/hello", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from /hello endpoints\n");
            //    });
            //});

            ////TRY 9
            ////NOTE: REQUEST TO /hello ENDPOINT
            ////Request incoming to middleware 1
            ////Request incoming to middleware 2
            ////Request incoming to middleware 3
            ////Request outcoming to middleware 3
            ////Request outcoming to middleware 2
            ////Request outcoming to middleware 1
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 1 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 2 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 2 \n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 3 \n");
            //    await context.Response.WriteAsync("Request outcoming to middleware 3 \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request incoming to middleware 3 \n");
            //    await next();
            //    await context.Response.WriteAsync("Request outcoming to middleware 3 \n");
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!\n");
            //    });

            //    endpoints.MapGet("/hello", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from /hello endpoints\n");
            //    });
            //});


            #endregion


            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h3> Request incoming to middleware 1 </h3> </div>");
            //    await next();
            //    await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h3> Request outcoming to middleware 1 </h3> </div>");
            //});

            //app.Run(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h3> Request incoming to middleware 2 </h3> </div>");
            //    await next();
            //    await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h3> Request outcoming to middleware 2 </h3> </div>");
            //});


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("<div style=\"text-align: center;\"> <h2> Request incoming to final middleware Run</h2> </div>");
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.Map("/", async context =>
                //{
                //    //throw new Exception("Some error while processing request");
                //    await context.Response.WriteAsync("Hello world");
                //});
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //    endpoints.MapGet("/", async context =>
            //        await context.Response.WriteAsync("Hello World!");
            //    });

            //endpoints.MapGet("/hello", async context =>
            // {
            //     await context.Response.WriteAsync("Hello from /hello endpoints");
            // });         
        }
    }
}
