using System;
using System.Runtime.Serialization;

namespace cEs.Infra.Exceptions
{
    [Serializable]
    public class cEsSqlServerDeleteException : Exception
    {
        public cEsSqlServerDeleteException()
        {
        }

        public cEsSqlServerDeleteException(string message)
            : base(message)
        {
        }

        public cEsSqlServerDeleteException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }

        public cEsSqlServerDeleteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public cEsSqlServerDeleteException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }

        //protected cEsSqlServerDeleteException(SerializationInfo info, StreamingContext context)
        //    : base(info, context)
        //{
        //}
    }
}
