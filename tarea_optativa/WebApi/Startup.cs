using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Servicio.Conversiones;
namespace WebApi
{
    /// <summary>
    /// Configuración inicial de la aplicación.
    /// Autor: [Tu Nombre]
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configura los servicios de la aplicación.
        /// </summary>
        /// <param name="services">Colección de servicios.</param>
        public void ConfigureServices(IServiceCollection services)
{
    // Registra el servicio FechaService para inyección de dependencias.
    services.AddScoped<FechaService>();

    // Agrega los servicios necesarios para controladores (MVC o API)
    services.AddControllers();
}

        /// <summary>
        /// Configura el pipeline de la aplicación.
        /// </summary>
        /// <param name="app">Aplicación configuradora.</param>
        /// <param name="env">Entorno actual.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

