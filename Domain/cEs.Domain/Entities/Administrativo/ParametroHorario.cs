using cEs.Domain.Interface.Entities.Administrativo;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Administrativo
{
    [DataContract]
    public class ParametroHorario : IParametroHorario
    {
        [DataMember]
        public long? ParametroHorarioId { get; set; }
        [DataMember]
        public string Horario { get; set; }
    }
}
