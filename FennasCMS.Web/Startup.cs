using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FennasCMS.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services
                .AddOrchardCms()
                //.AddOrchardCore()
                //.AddMvc()
                //.WithTenants()
            ;
        }
        
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseOrchardCore();
        }
    }
}
