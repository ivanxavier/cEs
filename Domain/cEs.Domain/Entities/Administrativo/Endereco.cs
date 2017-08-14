using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Administrativo;

namespace cEs.Domain.Entities.Administrativo
{
    [DataContract]
    public class Endereco: IEndereco
    {
        #region Implementation of IEndereco

        [DataMember]
        public string Cep { get; set; }

        [DataMember]
        public string Logradouro { get; set; }

        [DataMember]
        public string Numero { get; set; }

        [DataMember]
        public string Bairro { get; set; }

        [DataMember]
        public string Municipio { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public string Complemento { get; set; }

        #endregion
    }
}
