using cEs.Domain.Interface.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Comercial
{
    [DataContract]
    public class Contato : IContato
    {
        [DataMember]
        public long? ContatoId { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Telefone { get; set; }
        [DataMember]
        public string Mensagem { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Celular { get; set; }
        [DataMember]
        public bool Status { get; set; }
    }
}
