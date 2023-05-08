using DP.AbstractFactory.Cache;
using DP.AbstractFactory.Logger;

namespace DP.AbstractFactory.Factory
{
    internal abstract class CrossCuttingConcernsFactory : ICrossCuttingConcernsFactory
    {
        public abstract ICaching CreateCache();
        public abstract ILogger CreateLogger();
    }
}