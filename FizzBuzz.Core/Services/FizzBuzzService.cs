using FizzBuzz.Core.Rules;

namespace FizzBuzz.Core.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IFizzBuzzRuleFactory _ruleFactory;

        public FizzBuzzService(IFizzBuzzRuleFactory ruleFactory)
        {
            _ruleFactory = ruleFactory;
        }

        public string[] GetFizzBuzzRange(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start must be less than or equal to end");
            }

            var results = new string[end - start + 1];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = GetFizzBuzzResult(start + i);
            }
            return results;
        }

        public string GetFizzBuzzResult(int number)
        {
            var rule = _ruleFactory.GetRule(number);

            if (rule == null)
            {
                // There is no available rule so just return the number
                return number.ToString();
            }
            return rule.GetOutput();
        }
    }
}
