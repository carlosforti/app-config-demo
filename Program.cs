using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using System;

namespace app_config_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        //Host.CreateDefaultBuilder(args)
        //    .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

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
                                        .Register("TestApp:Settings:Message")
                                        .Register("TestApp:Settings:ConnectionString");
                                    refresh.SetCacheExpiration(TimeSpan.FromSeconds(5));
                                });
                        });
                    })
                    .UseStartup<Startup>());
    }
}
