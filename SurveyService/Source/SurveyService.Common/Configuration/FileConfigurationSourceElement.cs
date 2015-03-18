using System;
using System.Globalization;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;

namespace SurveyService.Common.Configuration
{
    public class FileConfigurationSourceElement :
        Microsoft.Practices.EnterpriseLibrary.Common.Configuration.FileConfigurationSourceElement
    {
        #region Methods

        public override IConfigurationSource CreateSource()
        {
            var configurationFilepath = GetRootedCurrentConfigurationFile(this.FilePath);
            return new Microsoft.Practices.EnterpriseLibrary.Common.Configuration.FileConfigurationSource(configurationFilepath);
        }

        private static string GetRootedCurrentConfigurationFile(string configurationFile)
        {
            if (string.IsNullOrEmpty(configurationFile))
            {
                throw new ArgumentException(Resources.ExceptionStringNullOrEmpty, "configurationFile");
            }

            var path = Path.IsPathRooted(configurationFile)
                           ? configurationFile
                           : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configurationFile);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.ExceptionConfigurationLoadFileNotFound,
                        path));
            }

            return path;
        }

        #endregion
    }
}