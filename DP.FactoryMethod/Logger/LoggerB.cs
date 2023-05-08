namespace DP.FactoryMethod.Logger
{
    internal class LoggerB : ILogger
    {
        public void Log()
        {
            Console.WriteLine($"Log with: {typeof(LoggerB).Name}");
        }
    }
}