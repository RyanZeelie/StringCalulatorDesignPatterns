using Calculator.Enums;
using Calculator.Factories;

namespace Calculator
{
    public class StringCalculator
    {
        public const int DefaultValue = 0;

        private readonly INumberServiceFactory _numberServiceFactory;
        public StringCalculator(INumberServiceFactory numberServiceFactory)
        {
            _numberServiceFactory = numberServiceFactory;   
        }

        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return DefaultValue;
            }

            var numberService = _numberServiceFactory.CreateNumberService(Operations.Add);

            var numbers = numberService.ParseNumbers(input);

            var additionResult = DefaultValue;

            foreach (var number in numbers)
            {
                additionResult += number;
            }

            return additionResult;
        }

        public int Subtract(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return DefaultValue;
            }

            var numberService = _numberServiceFactory.CreateNumberService(Operations.Subtract);

            var numbers = numberService.ParseNumbers(input);

            var subtractionResult = DefaultValue;

            foreach ( var number in numbers)
            {
                subtractionResult -= number;
            }

            return subtractionResult;
        }
    }
}