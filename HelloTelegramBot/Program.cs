using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloTelegramBot.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace HelloTelegramBot
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            LoggingExtension.ConfigureSerilog();

            await CreateHostBuilder(args).Build().RunAsync();

            Log.CloseAndFlush();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}