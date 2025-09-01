namespace FizzBuzz.Core.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public RulePriority Priority => RulePriority.Fizz;

        public bool IsMatch(int number) => number % 3 == 0;

        public string GetOutput() => "Fizz";
    }
}
