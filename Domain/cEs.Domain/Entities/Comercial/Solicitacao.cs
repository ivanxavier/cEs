using cEs.Domain.Interface.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace cEs.Domain.Entities.Comercial
{
    [DataContract]
    public class Solicitacao : ISolicitacao
    {
        [DataMember]
        public long? SolicitacaoId { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Endereco { get; set; }
        [DataMember]
        public int? Numero { get; set; }
        [DataMember]
        public string Complemento { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public string Municipio { get; set; }
        [DataMember]
        public string UF { get; set; }
        [DataMember]
        public string Cep { get; set; }
        [DataMember]
        public string Contato { get; set; }
        [DataMember]
        public string Celular { get; set; }
        [DataMember]
        public string Telefone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Assunto { get; set; }
        [DataMember]
        public string Procurar { get; set; }
        [DataMember]
        public string SolicitacaoStatusId { get; set; }
        [DataMember]
        public DateTime? Data { get; set; }

        [DataMember]
        public string Status { get; set; }
      }
   
}
