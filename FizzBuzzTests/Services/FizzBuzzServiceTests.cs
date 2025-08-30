using FizzBuzz.Core.Services;

namespace FizzBuzzTests.Services
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
            var fizzBuzzService = new FizzBuzzService();

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
            var fizzBuzzService = new FizzBuzzService();

            // Act
            string[] result = fizzBuzzService.GetFizzBuzzRange(start, end);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}