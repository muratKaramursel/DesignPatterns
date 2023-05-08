namespace DP.FactoryMethod.Logger
{
    internal class LoggerA : ILogger
    {
        public void Log()
        {
            Console.WriteLine($"Log with: {typeof(LoggerA).Name}");
        }
    }
}