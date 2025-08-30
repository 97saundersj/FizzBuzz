namespace FizzBuzz.Core.Services
{
    public interface IFizzBuzzService
    {
        /// <summary>
        /// Gets the FizzBuzz result for a single number
        /// </summary>
        /// <param name="number">The number to evaluate</param>
        /// <returns>FizzBuzz result</returns>
        string GetFizzBuzzResult(int number);

        /// <summary>
        /// Gets FizzBuzz results for a range of numbers
        /// </summary>
        /// <param name="start">Start of the range (inclusive)</param>
        /// <param name="end">End of the range (inclusive)</param>
        /// <returns>Array of FizzBuzz results</returns>
        string[] GetFizzBuzzRange(int start, int end);
    }
}
