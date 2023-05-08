namespace DP.Singleton
{
    public class SingleObject
    {
        private static SingleObject? _singleObject;
        private static readonly object _lockObject = new();

        public string CreateDate = $"{DateTime.Now:dd.MM.yyyy H:mm.ss}";
        
        private SingleObject()
        {
        }

        public static SingleObject GetInstance()
        {
            if (_singleObject == null)
                lock (_lockObject)
                    _singleObject ??= new();
            return _singleObject;
        }
    }
}