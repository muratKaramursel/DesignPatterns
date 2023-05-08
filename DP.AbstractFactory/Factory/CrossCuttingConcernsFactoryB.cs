using DP.AbstractFactory.Cache;
using DP.AbstractFactory.Logger;

namespace DP.AbstractFactory.Factory
{
    internal class CrossCuttingConcernsFactoryB : CrossCuttingConcernsFactory
    {
        public override ICaching CreateCache()
        {
            return new CachingB();
        }

        public override ILogger CreateLogger()
        {
            return new LoggerB();
        }
    }
}