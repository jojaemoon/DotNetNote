using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SponsorApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Microsoft Docs, ASP.NET Core Book Chaper 24
            app.UseDefaultFiles();      // index.html, default.htm, ....  ���� ����
            app.UseStaticFiles();       // wwwroot  ������ ������ �����ϱ� (HTML, CSS, JavaScript, ...)

            app.UseRouting();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Sponsor App");
                });
            });
        }
    }
}
