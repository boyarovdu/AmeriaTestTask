using Microsoft.Practices.Unity;

namespace SurveyService.Common.Unity
{
    public static class Shell
    {
        #region Fields

        private static readonly object LockObject = new object();

        private static volatile bool _isInitialized;

        private static ShellContainer _container;

        #endregion

        #region Public Methods

        public static void Start<T>() where T : UnityContainerExtension, new()
        {
            var initialization = new T();
            Start(initialization);
        }

        public static void Start(UnityContainerExtension initialization = null)
        {
            if (!_isInitialized)
            {
                lock (LockObject)
                {
                    if (!_isInitialized)
                    {
                        StartCore(initialization);
                        _isInitialized = true;
                    }
                }
            }
        }

        public static void Shutdown()
        {
            if (_isInitialized)
            {
                lock (LockObject)
                {
                    if (_isInitialized)
                    {
                        ShutdownCore();
                        _isInitialized = false;
                    }
                }
            }
        }

        public static void Restart()
        {
            lock (LockObject)
            {
                Shutdown();
                Start();
            }
        }

        #endregion

        #region Private Methods

        private static void StartCore(UnityContainerExtension initialization)
        {
            _container = new ShellContainer(initialization);
            _container.Register();
        }

        private static void ShutdownCore()
        {
            _container.Dispose();
            _container = null;
        }

        #endregion
    }
}