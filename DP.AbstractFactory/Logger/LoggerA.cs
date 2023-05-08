namespace DP.AbstractFactory.Logger
{
    internal class LoggerA : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"{message} logged with {typeof(LoggerA).Name}");
        }
    }
}