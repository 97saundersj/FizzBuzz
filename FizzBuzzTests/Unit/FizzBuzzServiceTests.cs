using FizzBuzz.Core.Rules;
using FizzBuzz.Core.Services;
using Moq;

namespace FizzBuzzTests.Unit
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        [TestMethod]
        public void GetFizzBuzzResult_WhenRuleExists_ReturnsRuleOutput()
        {
            // Arrange
            var mockRuleFactory = new Mock<IFizzBuzzRuleFactory>();
            var mockRule = new Mock<IFizzBuzzRule>();

            mockRule.Setup(r => r.GetOutput()).Returns("Fizz");
            mockRuleFactory.Setup(f => f.GetRule(3)).Returns(mockRule.Object);

            var service = new FizzBuzzService(mockRuleFactory.Object);

            // Act
            string result = service.GetFizzBuzzResult(3);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetFizzBuzzResult_WhenNoRuleExists_ReturnsNumberAsString()
        {
            // Arrange
            var mockRuleFactory = new Mock<IFizzBuzzRuleFactory>();
            mockRuleFactory.Setup(f => f.GetRule(7)).Returns((IFizzBuzzRule?)null);
            var service = new FizzBuzzService(mockRuleFactory.Object);

            // Act
            string result = service.GetFizzBuzzResult(7);

            // Assert
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void GetFizzBuzzRange_WithValidRange_GetsCorrectNumberOfResults()
        {
            // Arrange
            var mockRuleFactory = new Mock<IFizzBuzzRuleFactory>();
            mockRuleFactory.Setup(f => f.GetRule(It.IsAny<int>())).Returns((IFizzBuzzRule?)null);

            var mockService = new Mock<FizzBuzzService>(mockRuleFactory.Object);

            // Act
            string[] result = mockService.Object.GetFizzBuzzRange(1, 3);

            // Assert
            Assert.AreEqual(3, result.Length);
        }

        [TestMethod]
        public void GetFizzBuzzRange_WithInvalidRange_ThrowsException()
        {
            // Arrange
            var mockRuleFactory = new Mock<IFizzBuzzRuleFactory>();
            var service = new FizzBuzzService(mockRuleFactory.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => service.GetFizzBuzzRange(5, 1));
        }
    }
}
