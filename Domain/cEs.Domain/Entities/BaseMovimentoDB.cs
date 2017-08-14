using System;
using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities;

namespace cEs.Domain.Entities
{
    [DataContract]
    public abstract class BaseMovimentoDb : IBaseMovimentoDb
    {
        [DataMember]
        public DateTime InclusaoData { get; set; }
        [DataMember]
        public Int64 InclusaoUsuario { get; set; }
        [DataMember]
        public DateTime? AlteracaoData { get; set; }
        [DataMember]
        public Int64? AlteracaoUsuario { get; set; }
    }
}
