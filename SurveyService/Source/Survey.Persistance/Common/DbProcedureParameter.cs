using System;

namespace Survey.Persistance.Common
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DbProcedureParameter : Attribute
    {
        public string ParameterName { get; set; }

        public DbProcedureParameter(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
