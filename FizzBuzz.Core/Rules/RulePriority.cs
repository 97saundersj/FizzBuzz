namespace FizzBuzz.Core.Rules
{
    /// <summary>
    /// Defines the priority levels for FizzBuzz rules.
    /// Lower enum values have higher priority (are evaluated first).
    /// </summary>
    public enum RulePriority
    {
        /// <summary>
        /// FizzBuzz rule - highest priority, evaluated first
        /// </summary>
        FizzBuzz = 0,
        
        /// <summary>
        /// Fizz rule - medium priority, evaluated second
        /// </summary>
        Fizz = 1,
        
        /// <summary>
        /// Buzz rule - lowest priority, evaluated last
        /// </summary>
        Buzz = 2
    }
}
