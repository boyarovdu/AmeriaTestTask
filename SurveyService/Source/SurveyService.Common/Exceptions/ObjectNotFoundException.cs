using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace SurveyService.Common.Exceptions
{
    [Serializable]
    public class ObjectNotFoundException : RootException
    {
        #region Constructors

        public ObjectNotFoundException(string message, string id, string type, Exception ex)
            : base(message, ex)
        {
            this.ObjectId = id;
            this.ObjectType = type;
        }

        public ObjectNotFoundException(string message, string id, Type type, Exception ex)
            : this(message, id, type.Name, ex)
        {
        }

        public ObjectNotFoundException(string id, string type, Exception ex)
            : this(ToMessage(id, type), id, type, ex)
        {
        }

        public ObjectNotFoundException(string id, Type type, Exception ex)
            : this(id, type.Name, ex)
        {
        }

        public ObjectNotFoundException()
        {
        }

        public ObjectNotFoundException(string message)
            : base(message)
        {
        }

        public ObjectNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ObjectNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ObjectId = info.GetString("ObjectId");
            ObjectType = info.GetString("ObjectType");
        }

        #endregion

        #region Properties

        public string ObjectId { get; set; }

        public string ObjectType { get; set; }

        #endregion

        #region Methods

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ObjectId", this.ObjectId);
            info.AddValue("ObjectType", this.ObjectType);
        }

        private static string ToMessage(string id, string type)
        {
            Contract.Assert(type != null);
            var message = string.Format(
                    CultureInfo.InvariantCulture,
                    "Can not load object {0} by id {1}",
                    type,
                    id);
            return message;
        }

        #endregion
    }
}