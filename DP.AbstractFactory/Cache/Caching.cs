namespace DP.AbstractFactory.Cache
{
    internal abstract class Caching : ICaching
    {
        public abstract void Cache(object data);
    }
}