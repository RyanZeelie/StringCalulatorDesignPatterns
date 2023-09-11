namespace Calculator
{
    public class StringCalculator
    {
        public const int DefaultValue = 0;

        public StringCalculator()
        {
            
        }

        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return DefaultValue;
            }

            var additionResult = DefaultValue;

            return additionResult;
        }

        public int Subtract(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return DefaultValue;
            }

            var subtractionResult = DefaultValue;

            return subtractionResult;
        }
    }
}