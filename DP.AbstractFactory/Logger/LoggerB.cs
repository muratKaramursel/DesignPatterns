namespace DP.AbstractFactory.Logger
{
    internal class LoggerB : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"{message} logged with {typeof(LoggerB).Name}");
        }
    }
}