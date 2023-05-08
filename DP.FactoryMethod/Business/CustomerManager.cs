using DP.FactoryMethod.Logger;

namespace DP.FactoryMethod.Business
{
    internal class CustomerManager
    {
        private readonly ILogger _logger;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger();
        }

        public void SaveCustomer()
        {
            Console.WriteLine("Customer Saved");
            _logger.Log();
        }
    }
}