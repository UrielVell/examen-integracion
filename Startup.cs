using SoapCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace grados
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<iGrados, Grados>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSoapEndpoint<iGrados>("/grados.asmx", new SoapEncoderOptions(), 
                    SoapSerializer.XmlSerializer);
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}