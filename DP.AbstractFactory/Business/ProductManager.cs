using DP.AbstractFactory.Cache;
using DP.AbstractFactory.Factory;
using DP.AbstractFactory.Logger;

namespace DP.AbstractFactory.Business
{
    internal class ProductManager
    {
        private readonly ICrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private readonly ILogger _logger;
        private readonly ICaching _caching;

        public ProductManager(ICrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logger = _crossCuttingConcernsFactory.CreateLogger();
            _caching = _crossCuttingConcernsFactory.CreateCache();
        }

        public void GetAll()
        {
            _logger.Log("Products");
            _caching.Cache("Products");
            Console.WriteLine("Products Listed");
        }
    }
}