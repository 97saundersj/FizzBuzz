using FizzBuzz.Core.Services;

namespace FizzBuzz
{
    internal class FizzBuzzRunner
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzRunner(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        public void Run()
        {
            Console.WriteLine("FizzBuzz!");
            
            // Get FizzBuzz results from 1 to 100
            var results = _fizzBuzzService.GetFizzBuzzRange(1, 100);
            
            // Display the results
            Console.WriteLine("FizzBuzz results from 1 to 100:");
            Console.WriteLine("=================================");
            
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {results[i]}");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
