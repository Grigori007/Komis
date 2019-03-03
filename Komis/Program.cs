using Komis.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Komis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // kreacja hosta
            // CreateWebHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // uzywamy tu Dependency Injection by zyskac dostep do kontenera zaleznosci AppDbContext
                    var context = services.GetRequiredService<AppDbContext>();
                    context.Database.Migrate();
                    DbInitializer.Seed(context);
                }
                catch(Exception ex)
                {

                }
            }

            host.Run();
        }

        // konfiguracja hosta z pewnymi wstpenymi danymi. Odczytuje automatycznie plik appsettings.json
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
