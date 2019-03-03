using Komis.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Komis
{
    public class Startup
    {
        // instancja IConfiguration zawiera wszystkie informacje odczytane w Program.cs . Teraz mozna uzyc instacji konfiguracji by zapewnic ciag polaczenia.
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // rejestrowanie uslug (dependency injection)
        public void ConfigureServices(IServiceCollection services)
        {
            // uslugi -> obiekty, ktore maja okreslona funkcjonalnosci dla innych czesci aplikacji

            // Dodaje obsluge bazy danych. Okreslamy tu tez rowniez ze bedziemy uzywac SQL Server. Poza tym w pliku appsettings.json trzeba skonfigurowac ConnectionString. Uzywamy instancji konfiguracji by zapewnic ciag polaczen.
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Za kazdym razem gdy ktos poprosi o instancje ICarRepository, zamiast tego dana mu zostanie instancja klasy testowej MockCarRepository. EDIT: Teraz dajemy instancje CarRepository obslugujaca baze danych.
            services.AddTransient<ICarRepository, CarRepository>();
            // Zamiast AddTransient() pozniej bedzie trzeba uzyc AddScoped lub AddSingleton???
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            // ten komponent powinien byc zawsze? na koncu
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
