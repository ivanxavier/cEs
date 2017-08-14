using System;
using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;
using cEs.Domain.Interface.Entities;

namespace cEs.Domain.Entities.Seguranca
{
    [DataContract]
    public class Usuario: IUsuario
    {
        #region Implementation of IUsuario

        [DataMember]
        public long? UsuarioId { get; set; }

        [DataMember]
        public string Nome{ get; set; }

        [DataMember]
        public string TelefoneDDD { get; set; }

        [DataMember]
        public string TelefoneNumero { get; set; }

        [DataMember]
        public string Email { get; set; }

        //[DataMember]
        //public DateTime? AlteracaoData { get; set; }
        //[DataMember]
        //public long? AlteracaoUsuario { get; set; }
        //[DataMember]
        //public DateTime InclusaoData { get; set; }
        //[DataMember]
        //public long InclusaoUsuario { get; set; }

        #endregion
    }
}
