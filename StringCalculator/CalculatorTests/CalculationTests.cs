using Calculator;

namespace CalculatorTests
{
    [TestFixture]   
    public class CalculationTests
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void Setup()
        {
            _stringCalculator = new StringCalculator();
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
    }
}