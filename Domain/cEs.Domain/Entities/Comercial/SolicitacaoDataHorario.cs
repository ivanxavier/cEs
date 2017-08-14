using cEs.Domain.Interface.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Comercial
{
    [DataContract]
    public class SolicitacaoDataHorario : ISolicitacaoDataHorario
    {
        [DataMember]
        public long? SolicitacaoDataHorarioId { get; set; }
        [DataMember]
        public string Inicio { get; set; }
        [DataMember]
        public string Termino { get; set; }
        [DataMember]
        public long? SolicitacaoDataId { get; set; }
    }
}
