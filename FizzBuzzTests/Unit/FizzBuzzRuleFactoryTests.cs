using FizzBuzz.Core.Rules;

namespace FizzBuzzTests.Unit
{
    [TestClass]
    public class FizzBuzzRuleFactoryTests
    {
        [TestMethod]
        [DataRow(3)] // Fizz
        [DataRow(5)] // Buzz
        [DataRow(15)] // Fizzbuzz
        public void GetRule_ReturnsCorrectRule(int number)
        {
            // Arrange
            var factory = new FizzBuzzRuleFactory();

            // Act
            var rule = factory.GetRule(number);

            // Assert
            Assert.IsNotNull(rule);
            Assert.IsInstanceOfType(rule, typeof(IFizzBuzzRule));
        }
    }
}
