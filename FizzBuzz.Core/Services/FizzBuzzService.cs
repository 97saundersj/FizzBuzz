namespace FizzBuzz.Core.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string[] GetFizzBuzzRange(int start, int end)
        {
            if (start > end)
                throw new ArgumentException("Start must be less than or equal to end");

            var results = new string[end - start + 1];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = GetFizzBuzzResult(start + i);
            }
            return results;
        }

        public string GetFizzBuzzResult(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();
        }
    }
}
