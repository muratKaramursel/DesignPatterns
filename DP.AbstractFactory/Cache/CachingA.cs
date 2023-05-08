namespace DP.AbstractFactory.Cache
{
    internal class CachingA : Caching
    {
        public override void Cache(object data)
        {
            Console.WriteLine($"{data} cached with {typeof(CachingA).Name}");
        }
    }
}