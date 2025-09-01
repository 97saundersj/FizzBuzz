namespace FizzBuzz.Core.Rules
{
    public class BuzzRule : IFizzBuzzRule
    {
        public RulePriority Priority => RulePriority.Buzz;

        public bool IsMatch(int number) => number % 5 == 0;

        public string GetOutput() => "Buzz";
    }
}
