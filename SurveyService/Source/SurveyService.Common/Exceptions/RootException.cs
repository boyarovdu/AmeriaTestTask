using System;
using System.Runtime.Serialization;

namespace SurveyService.Common.Exceptions
{
    [Serializable]
    public class RootException : Exception
    {
        #region Constructors

        public RootException()
        {
        }

        public RootException(string message)
            : base(message)
        {
        }

        public RootException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected RootException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}