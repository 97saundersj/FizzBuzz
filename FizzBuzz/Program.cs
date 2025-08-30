using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configure services and get the service provider
            var serviceProvider = ServiceConfiguration.ConfigureServices();
            
            // Get and run the FizzBuzzRunner
            var runner = serviceProvider.GetRequiredService<FizzBuzzRunner>();
            runner.Run();
        }
    }
}
