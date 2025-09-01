namespace FizzBuzz.Core.Rules
{
    public interface IFizzBuzzRuleFactory
    {
        /// <summary>
        /// Gets the first matching rule for a given number
        /// </summary>
        /// <param name="number">The number to evaluate</param>
        /// <returns>The relevant rule, or null if no relevant rule is found</returns>
        IFizzBuzzRule? GetRule(int number);
    }
}
