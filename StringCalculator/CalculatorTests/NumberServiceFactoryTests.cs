using Calculator.Enums;
using Calculator.Factories;
using Calculator.Services.Numbers;

namespace CalculatorTests
{
    [TestFixture]
    public class NumberServiceFactoryTests
    {
        private INumberServiceFactory _numberServiceFactory;

        [SetUp]
        public void Setup()
        {
            _numberServiceFactory = new NumberServiceFactory();
        }

        [Test]
        public void GIVEN_AddOperation_WHEN_CreatingNumberService_RETURNS_AdditionNumberService()
        {
            // Act
            var AdditionNumberService = _numberServiceFactory.CreateNumberService(Operations.Add);

            //Asset
            Assert.IsInstanceOf<AdditionNumberService>(AdditionNumberService);
        }

        [Test]
        public void GIVEN_SubtractOperation_WHEN_CreatingNumberService_RETURNS_SubtractionNumberService()
        {
            // Act
            var subtractionNumberService = _numberServiceFactory.CreateNumberService(Operations.Subtract);

            //Asset
            Assert.IsInstanceOf<SubtractionNumberService>(subtractionNumberService);
        }
    }
}
