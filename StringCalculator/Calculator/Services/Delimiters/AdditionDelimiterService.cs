namespace Calculator.Services.Delimiters
{
    public class AdditionDelimiterService : IDelimiterService
    {
        public string[] GetDelimiters(string inputString, string delimiterIndicator)
        {
            var delimiters = new List<string> { ",", "\n" };

            return delimiters.ToArray();
        }
    }
}
