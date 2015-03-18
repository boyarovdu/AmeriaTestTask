using System;
using System.Diagnostics.Contracts;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SurveyService.Common.Exceptions
{
    public static class ExceptionExtension
    {
        public static Exception TransformException(this Exception ex, string policyName)
        {
            Contract.Assert(policyName != null);

            var transformedException = ex;
            if (ex != null)
            {
                Exception exceptionToThrow;
                var rethrow = ExceptionPolicy.HandleException(ex, policyName, out exceptionToThrow);
                if (rethrow && exceptionToThrow != null)
                {
                    transformedException = exceptionToThrow;
                }
            }

            return transformedException;
        }
    }
}
