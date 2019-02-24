using Komis.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Komis
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // rejestrowanie uslug (dependency injection)
        public void ConfigureServices(IServiceCollection services)
        {
            // uslugi -> obiekty, ktore maja okreslona funkcjonalnosci dla innych czesci aplikacji

            // Za kazdym razem gdy ktos poprosi o instancje ICarRepository, zamiast tego dana mu zostanie instancja klasy testowej MockCarRepository
            services.AddTransient<ICarRepository, MockCarRepository>();
            // Zamiast AddTransient() pozniej bedzie trzeba uzyc AddScoped lub AddSingleton
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute(); // ten komponent powinien byc zawsze? na kocu

        }
    }
}
