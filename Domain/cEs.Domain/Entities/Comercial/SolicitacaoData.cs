using cEs.Domain.Interface.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Comercial
{
    [DataContract]
    public class SolicitacaoData : ISolicitacaoData
    {
        [DataMember]
        public long? SolicitacaoDataId { get; set; }
        [DataMember]
        public DateTime Data { get; set; }
        [DataMember]
        public long? SolicitacaoId { get; set; }
    }
}
