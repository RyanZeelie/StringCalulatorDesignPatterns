using Calculator.Services.Delimiters;

namespace Calculator.Services.Numbers
{
    public class AdditionNumberService : INumberService
    {
        private IDelimiterService _delimiterService;

        public AdditionNumberService(IDelimiterService delimiterService)
        {
            _delimiterService = delimiterService;
        }

        public List<int> ParseNumbers(string input)
        {
            throw new NotImplementedException();
        }
    }
}
