using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Navigation;

namespace FennasCMS
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<INavigationProvider, AdminMenu>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            //routes.MapAreaControllerRoute(
            //    name: "Home",
            //    areaName: "FennasCMS",
            //    pattern: "",
            //    defaults: new { controller = "Home", action = "Index" }
            //);

            //routes.MapAreaControllerRoute(
            //    name: "DemoNav",
            //    areaName: "FennasCMS",
            //    pattern: "",
            //    defaults: new { controller = "DemoNav", action = "Index" }
            //);
        }
    }
}