using cEs.Domain.Interface.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Comercial
{
    [DataContract]
    public class SolicitacaoStatus : ISolicitacaoStatus
    {
        [DataMember]
        public string SolicitacaoStatusId { get; set; }
        [DataMember]
        public string Nome { get; set; }
        
    }
}
