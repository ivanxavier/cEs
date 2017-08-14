using System;
using System.Runtime.Serialization;

namespace cEs.Infra.Exceptions
{
    [Serializable]
    public class cEsUniqueConstraintException : Exception
    {
        public cEsUniqueConstraintException() 
        {
        }

        public cEsUniqueConstraintException(string message) : base(message)
        {
        }

        public cEsUniqueConstraintException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }

        public cEsUniqueConstraintException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public cEsUniqueConstraintException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }

        protected cEsUniqueConstraintException(SerializationInfo info, StreamingContext context)
            : base(info.ToString(), null)
        {
        }
    }
}
