using FizzBuzz.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz
{
    public static class ServiceConfiguration
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register the FizzBuzz service
            services.AddScoped<IFizzBuzzService, FizzBuzzService>();

            // Register the FizzBuzzRunner
            services.AddScoped<FizzBuzzRunner>();

            // Build and return the service provider
            return services.BuildServiceProvider();
        }
    }
}
