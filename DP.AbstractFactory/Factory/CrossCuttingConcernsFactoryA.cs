using DP.AbstractFactory.Cache;
using DP.AbstractFactory.Logger;

namespace DP.AbstractFactory.Factory
{
    internal class CrossCuttingConcernsFactoryA : CrossCuttingConcernsFactory
    {

        public override ICaching CreateCache()
        {
            return new CachingA();
        }

        public override ILogger CreateLogger()
        {
            return new LoggerA();
        }
    }
}