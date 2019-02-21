using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Komis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // kreacja hosta
            CreateWebHostBuilder(args).Build().Run();
        }

        // konfiguracja hosta z pewnymi wstpenymi danymi
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
