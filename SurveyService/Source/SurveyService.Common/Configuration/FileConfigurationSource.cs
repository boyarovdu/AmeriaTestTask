using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace SurveyService.Common.Configuration
{
    [ConfigurationElementType(typeof(FileConfigurationSourceElement))]
    public class FileConfigurationSource : Microsoft.Practices.EnterpriseLibrary.Common.Configuration.FileConfigurationSource
    {
        public FileConfigurationSource(string configurationFilePath)
            : base(configurationFilePath)
        {
        }
    }
}