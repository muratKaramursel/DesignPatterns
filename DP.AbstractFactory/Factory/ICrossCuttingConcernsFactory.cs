using DP.AbstractFactory.Cache;
using DP.AbstractFactory.Logger;

namespace DP.AbstractFactory.Factory
{
    internal interface ICrossCuttingConcernsFactory
    {
        public ILogger CreateLogger();
        public ICaching CreateCache(); 
    }
}