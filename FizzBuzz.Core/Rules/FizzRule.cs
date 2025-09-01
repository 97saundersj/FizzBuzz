namespace FizzBuzz.Core.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public int Priority => 2;

        public bool IsMatch(int number) => number % 3 == 0;

        public string GetOutput() => "Fizz";
    }
}
