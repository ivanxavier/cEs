using cEs.Domain.Interface.Entities.Administrativo;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Administrativo
{
    [DataContract]
    public class Uf : IUf
    {
        [DataMember]
        public string UfId { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
