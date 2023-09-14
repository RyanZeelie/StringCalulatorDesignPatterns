using Calculator.Helpers;
using Calculator.Services.Delimiters;

namespace Calculator.Services.Numbers
{
    public class AdditionNumberService : INumberService
    {
        private IDelimiterService _delimiterService;

        private const string DelimiterIndicator = "//";

        public AdditionNumberService(IDelimiterService delimiterService)
        {
            _delimiterService = delimiterService;
        }

        public List<int> ParseNumbers(string input)
        {
            var numbersWithoutDelimiters = RemoveDelimitersFromInputString(input);

            return ServiceHelpers.ParseNumbersToInt(numbersWithoutDelimiters);  
        }

        private string[] RemoveDelimitersFromInputString(string inputString)
        {
            var delimiters = _delimiterService.GetDelimiters(inputString, DelimiterIndicator);

            return inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
