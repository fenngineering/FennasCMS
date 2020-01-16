using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FennasCMS.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCore().AddMvc().WithTenants();
                //.AddSitesFolder().AddSetupFeatures().AddTheming().AddThemingHost().AddTenantFeatures().WithFeatures().WithTenants().AddBackgroundService().AddCaching.();
        }
        
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseStaticFiles();

            app.UseOrchardCore();

        }
    }
}
