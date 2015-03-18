using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.ServiceLocation;

namespace SurveyService.Common.Unity
{
    public static class ShellContainerExtension
    {
        public static void Register(this ShellContainer container)
        {
            ServiceLocator.SetLocatorProvider(() => container.Locator);
            ExceptionPolicy.SetExceptionManager(container.ExceptionManager, false);
        }
    }
}