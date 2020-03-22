using System;
using System.IO;
using FutTrader.Domain.FutApi;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Polly;

[assembly: FunctionsStartup(typeof(FutTrader.Scheduler.Functions.Startup))]
namespace FutTrader.Scheduler.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var hostDir = Environment.GetEnvironmentVariable("AzureWebJobsScriptRoot");
            if (!string.IsNullOrEmpty(hostDir))
            {
                Console.WriteLine($"Changing directory to {hostDir}");
                Directory.SetCurrentDirectory(hostDir);
            }

            builder.Services.AddHttpClient<IFutApi, FutApi>()
                .AddTransientHttpErrorPolicy(p =>
                    p.WaitAndRetryAsync(5, _ => TimeSpan.FromMilliseconds(600)));
        }
    }
}