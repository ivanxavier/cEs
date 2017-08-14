using System;
using System.Runtime.Serialization;

namespace cEs.Infra.Exceptions
{
    [Serializable]
    public class cEsPrimaryKeyException : Exception
    {
        public cEsPrimaryKeyException() 
        {
        }

        public cEsPrimaryKeyException(string message) : base(message)
        {
        }

        public cEsPrimaryKeyException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }

        public cEsPrimaryKeyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public cEsPrimaryKeyException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }

        protected cEsPrimaryKeyException(SerializationInfo info, StreamingContext context)
            : base(info.ToString(), null)
        {
        }

    }
}
