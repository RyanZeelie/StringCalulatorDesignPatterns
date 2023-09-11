using Calculator;
using Calculator.Enums;
using Calculator.Factories;
using Calculator.Services.Numbers;
using NSubstitute;

namespace CalculatorTests
{
    [TestFixture]   
    public class CalculationTests
    {
        private StringCalculator _stringCalculator;

        private INumberServiceFactory _mockNumberServiceFactory;
        private INumberService _mockNumberService;

        [SetUp]
        public void Setup()
        {
            _mockNumberServiceFactory = Substitute.For<INumberServiceFactory>();
            _mockNumberService = Substitute.For<INumberService>();

            _mockNumberServiceFactory.CreateNumberService(Operations.Add).Returns(_mockNumberService);
            _mockNumberServiceFactory.CreateNumberService(Operations.Subtract).Returns(_mockNumberService);

            _stringCalculator = new StringCalculator(_mockNumberServiceFactory);
        }

        [TestCase("")]
        [TestCase(null)]
        public void GIVEN_NullOrEmptyInput_WHEN_AddingInput_RETURNS_DefaultValue(string input)
        {
            //Arrange
            var expectedResult = 0;

            //Act
            var additionResult = _stringCalculator.Add(input);

            //Assert
            Assert.That(additionResult, Is.EqualTo(expectedResult));    
        }

        [TestCase("")]
        [TestCase(null)]
        public void GIVEN_NullOrEmptyInput_WHEN_SubtractingInput_RETURNS_DefaultValue(string input)
        {
            //Arrange
            var expectedResult = 0;

            //Act
            var subtractionResult = _stringCalculator.Add(input);

            //Assert
            Assert.That(subtractionResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_ListOfIntNumbers_WHEN_AddingNumbers_RETURNS_AdditionResult()
        {
            //Arrange
            var input = "1,2,3";
            var expectedResult = 6;

            //Act
            _mockNumberService.ParseNumbers(input).Returns(new List<int>() {1, 2, 3 });

            var additionResult = _stringCalculator.Add(input);

            //Assert
            Assert.That(additionResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_ListOfIntNumbers_WHEN_SubtractingNumbers_RETURNS_SubtractionResult()
        {
            //Arrange
            var input = "1,2,3";
            var expectedResult = -6;

            //Act
            _mockNumberService.ParseNumbers(input).Returns(new List<int>() { 1, 2, 3 });

            var additionResult = _stringCalculator.Subtract(input);

            //Assert
            Assert.That(additionResult, Is.EqualTo(expectedResult));
        }
    }
}