using System.Reflection;

namespace FizzBuzz.Core.Rules
{
    public class FizzBuzzRuleFactory : IFizzBuzzRuleFactory
    {
        private readonly IEnumerable<IFizzBuzzRule> _rules;

        public FizzBuzzRuleFactory()
        {
            _rules = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (IFizzBuzzRule)Activator.CreateInstance(t)!)
                .OrderBy(r => r.Priority);
        }

        public IFizzBuzzRule? GetRule(int number)
        {
            return _rules.FirstOrDefault(r => r.IsMatch(number));
        }
    }
}
