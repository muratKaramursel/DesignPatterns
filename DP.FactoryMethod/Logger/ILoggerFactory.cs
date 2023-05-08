namespace DP.FactoryMethod.Logger
{
    internal interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}