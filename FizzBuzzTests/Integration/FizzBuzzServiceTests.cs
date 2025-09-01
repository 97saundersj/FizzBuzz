using FizzBuzz;
using FizzBuzz.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzzTests.Integration
{
    [TestClass()]
    public class FizzBuzzServiceTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        public void GetFizzBuzzResult_ReturnsCorrectResult(int number, string expected)
        {
            // Arrange
            var serviceProvider = ServiceConfiguration.ConfigureServices();
            var fizzBuzzService = serviceProvider.GetRequiredService<IFizzBuzzService>();

            // Act
            string result = fizzBuzzService.GetFizzBuzzResult(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, 5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [DataRow(10, 15, new string[] { "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void GetFizzBuzzRange_ReturnsCorrectSequence(int start, int end, string[] expected)
        {
            // Arrange
            var serviceProvider = ServiceConfiguration.ConfigureServices();
            var fizzBuzzService = serviceProvider.GetRequiredService<IFizzBuzzService>();

            // Act
            string[] result = fizzBuzzService.GetFizzBuzzRange(start, end);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFizzBuzzRange_InvalidStartAndEnd_ReturnsError()
        {
            var start = 10;
            var end = 1;

            // Arrange
            var serviceProvider = ServiceConfiguration.ConfigureServices();
            var fizzBuzzService = serviceProvider.GetRequiredService<IFizzBuzzService>();

            // Act & Assert

            Assert.ThrowsException<ArgumentException>(() => fizzBuzzService.GetFizzBuzzRange(start, end));
        }
    }
}