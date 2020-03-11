using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace app_config_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var settings = config.Build();
                        config.AddAzureAppConfiguration(options =>
                        {
                            var appConfig = Environment.GetEnvironmentVariable("APP_CONFIG");
                            options.Connect(appConfig)
                                   .ConfigureRefresh(refresh =>
                                                     {
                                                         refresh.Register("TestApp:Settings:BackgroundColor")
                                                                .Register("TestApp:Settings:FontColor")
                                                                .Register("TestApp:Settings:FontColor")
                                                                .Register("TestApp:Settings:FontSize")
                                                                .Register("TestApp:Settings:Message");
                                                         refresh.SetCacheExpiration(TimeSpan.FromSeconds(5));
                                                     });
                        });
                    })
                .UseStartup<Startup>())
    }
}
