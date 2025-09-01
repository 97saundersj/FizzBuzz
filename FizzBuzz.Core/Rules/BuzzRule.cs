namespace FizzBuzz.Core.Rules
{
    public class BuzzRule : IFizzBuzzRule
    {
        public int Priority => 1;

        public bool IsMatch(int number) => number % 5 == 0;

        public string GetOutput() => "Buzz";
    }
}
