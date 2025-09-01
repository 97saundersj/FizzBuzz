namespace FizzBuzz.Core.Rules
{
    public class FizzBuzzRule : IFizzBuzzRule
    {
        public int Priority => 0;

        public bool IsMatch(int number) => number % 3 == 0 && number % 5 == 0;

        public string GetOutput() => "FizzBuzz";
    }
}
