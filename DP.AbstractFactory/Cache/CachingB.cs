namespace DP.AbstractFactory.Cache
{
    internal class CachingB : Caching
    {
        public override void Cache(object data)
        {
            Console.WriteLine($"{data} cached with {typeof(CachingB).Name}");
        }
    }
}