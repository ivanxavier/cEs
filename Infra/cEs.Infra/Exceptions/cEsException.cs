using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace cEs.Infra.Exceptions
{
    public class cEsException: Exception
    {
        public cEsException()
        {
            Debug.WriteLine("cEsException: *");
            throw new FaultException();
        }
        //public cEsException() : base(message)
        //{
        //    Debug.WriteLine("cEsException: {0}", message);
        //    throw new FaultException<cEsException>(this);
        //}

        public cEsException(string format, params object[] args)
            : base(string.Format(format, args))
        {
            Debug.WriteLine("cEsException: {0}", string.Format(format, args));
            throw new FaultException();
        }

        public cEsException(string message, Exception innerException)
            : base(message, innerException)
        {
            Debug.WriteLine("cEsException: {0}", message);
            throw new FaultException();
        }

        public cEsException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
            Debug.WriteLine("cEsException: {0}", string.Format(format, args));
            throw new FaultException();
        }

        protected cEsException(SerializationInfo info, StreamingContext context)
            : base(info.ToString(), null)
        {
            Debug.WriteLine("cEsException: [SerializationInfo]");
            throw new FaultException();
        }

    }
}