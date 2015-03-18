using System;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;

namespace SurveyService.Common.Exceptions
{
    [Serializable]
    public class ExecutionException : RootException
    {
        #region Constructors and Destructors

        public ExecutionException()
        {
        }

        public ExecutionException(string message)
            : base(message)
        {
        }

        public ExecutionException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected ExecutionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Contract.Assert(info != null);

            ErrorCode = info.GetInt32("Code");
            ErrorSubcode = info.GetInt32("Subcode");
            ErrorSource = info.GetString("ErrorSource");
        }

        #endregion

        #region Properties

        public int ErrorCode { get; set; }

        public int ErrorSubcode { get; set; }

        public string ErrorSource { get; set; }

        #endregion

        #region Methods

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Code", ErrorCode);
            info.AddValue("Subcode", ErrorSubcode);
            info.AddValue("ErrorSource", ErrorSource);
        }

        #endregion
    }
}