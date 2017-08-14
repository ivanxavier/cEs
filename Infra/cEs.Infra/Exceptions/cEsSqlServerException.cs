using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace cEs.Infra.Exceptions
{
    [Serializable]
    public class cEsSqlServerException : Exception
    {
        public cEsSqlServerException(string message, SqlException sqlException) : base(message, sqlException)
        {
            Debug.WriteLine("cEsSqlServerException: {0}", sqlException.Number);

            //Debug.WriteLine("Erro: {0} :: {1}", sqlError.Number, sqlError.Message);
            switch (sqlException.Number)
            {
                case 547:  // Problemas no delete
                    throw new FaultException();
                    break;
                case 2601: // Unique Constraint
                    throw new FaultException();
                    break;
                case 544: // Primary Key com SET IDENTITY_INSERT <tabela> IS OFF
                case 2627: // Primary Key ??? 
                    throw new FaultException();
                    break;
                default:
                    // caso não encontre nenhum erro de sql a ser tratado, gera uma nova exception genérica
                    throw new FaultException();
                    break;
                    //throw new SiciException(message, sqlException);
            }
        }

        public cEsSqlServerException() 
        {
        }

        public cEsSqlServerException(string message) : base(message)
        {
        }

        public cEsSqlServerException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }

        protected cEsSqlServerException(SerializationInfo info, StreamingContext context)
            : base(info.ToString(), null)
        {
        }
    }
}
