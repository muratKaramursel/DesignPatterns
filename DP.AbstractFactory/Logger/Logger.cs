namespace DP.AbstractFactory.Logger
{
    internal abstract class Logger : ILogger
    {
        public abstract void Log(string message);
    }
}