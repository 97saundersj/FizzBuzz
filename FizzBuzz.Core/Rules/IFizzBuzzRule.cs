namespace FizzBuzz.Core.Rules
{
    /// <summary>
    /// Defines a rule for the FizzBuzz game.
    /// </summary>
    public interface IFizzBuzzRule
    {
        /// <summary>
        /// Gets the priority of this rule. Lower enum values are evaluated first.
        /// </summary>
        RulePriority Priority { get; }

        /// <summary>
        /// Determines if the given number matches this rule.
        /// </summary>
        /// <param name="number">The number to evaluate.</param>
        /// <returns>True if the number matches; otherwise false.</returns>
        bool IsMatch(int number);

        /// <summary>
        /// Gets the output string when this rule matches.
        /// </summary>
        /// <returns>The output string (e.g., "Fizz", "Buzz").</returns>
        string GetOutput();
    }
}
