using Calculator.Enums;
using Calculator.Services.Numbers;

namespace Calculator.Factories
{
    public class NumberServiceFactory : INumberServiceFactory
    {
        public INumberService CreateNumberService(Operations operation)
        {
            throw new NotImplementedException();
        }
    }
}
