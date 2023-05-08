namespace DP.FactoryMethod.Logger
{
    internal class LoggerFactory : ILoggerFactory
    {
        private static LoggerFactory? _loggerFactory;
        private static readonly object _lockObject = new();

        private LoggerFactory()
        {
        }

        public ILogger CreateLogger()
        {
            //Configten Logger tipini okudum.
            int loggerType = 2;

            switch (loggerType)
            {
                case 1:
                    return new LoggerA();
                case 2:
                    return new LoggerB();
                default:
                    throw new Exception("Logger Type Bulunamadı");
            }
        }

        public static LoggerFactory GetInstance()
        {
            if (_loggerFactory == null)
                lock (_lockObject)
                    _loggerFactory ??= new();
            return _loggerFactory;
        }
    }
}