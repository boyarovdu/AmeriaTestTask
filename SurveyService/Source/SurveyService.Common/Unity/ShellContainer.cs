using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace SurveyService.Common.Unity
{
    public class ShellContainer : IDisposable
    {
        #region Fields

        private bool _disposed;

        #endregion

        #region Constructors

        public ShellContainer(UnityContainerExtension initialization = null)
        {
            Locator = CreateLocator(initialization);
            ExceptionManager = CreateExceptionManager();
        }

        ~ShellContainer()
        {
            Dispose(false);
        }

        #endregion

        #region Properties

        public IServiceLocator Locator { get; private set; }

        public ExceptionManager ExceptionManager { get; private set; }

        #endregion

        #region Public Methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Private Methods

        private static IServiceLocator CreateLocator(UnityContainerExtension initialization)
        {
            var configurationSource = ConfigurationSourceFactory.Create();

            var container = new UnityContainer()
                .RegisterType<IConfigurationSource>(
                    new ContainerControlledLifetimeManager(),
                    new InjectionFactory(c => configurationSource));

            var locator = new UnityServiceLocator(container);

            if (initialization != null)
            {
                container.AddExtension(initialization);
            }

            return locator;
        }

        private ExceptionManager CreateExceptionManager()
        {
            Contract.Assert(Locator != null);
            var policies = from list in Locator.GetAllInstances<IEnumerable<ExceptionPolicyData>>()
                           where list != null
                           from data in list
                           where data != null
                           let policy = data.BuildExceptionPolicy()
                           where policy != null
                           select policy;

            var exceptionManager = new ExceptionManager(policies);
            return exceptionManager;
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Destroy();
                }

                _disposed = true;
            }
        }

        private void Destroy()
        {
            Contract.Assert(Locator != null);
            var container = Locator.GetInstance<IUnityContainer>();
            container.Dispose();
        }

        #endregion
    }
}