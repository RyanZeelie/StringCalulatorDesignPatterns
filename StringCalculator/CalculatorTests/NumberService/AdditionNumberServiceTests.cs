using Calculator.Enums;
using Calculator.Factories;
using Calculator.Services.Delimiters;
using Calculator.Services.Numbers;
using NSubstitute;

namespace CalculatorTests.NumberService
{
    [TestFixture]
    public class AdditionNumberServiceTests
    {
        private INumberServiceFactory _mockNumberServiceFactory;
        private INumberService _numberService;

        [SetUp]
        public void Setup()
        {
            _mockNumberServiceFactory = Substitute.For<INumberServiceFactory>();
            _mockNumberServiceFactory.CreateNumberService(Operations.Add).Returns(CreateNumberService());

            _numberService = _mockNumberServiceFactory.CreateNumberService(Operations.Add);
        }

        [TestCase("1,2,3")]
        [TestCase("1\n2\n3")]
        public void GIVEN_NumbersSeperatedByDefaultDelimiters_WHEN_ParsingNumbers_RETURNS_ListOfNumbersAsInt(string input)
        {
            // Arrange
            var expectedResult = new List<int>() { 1, 2, 3 };

            // Act
            var result = _numberService.ParseNumbers(input);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        private INumberService CreateNumberService()
        {
            var delimiterService = new AdditionDelimiterService();
            var numberService = new AdditionNumberService(delimiterService);

            return numberService;
        }
    }
}
