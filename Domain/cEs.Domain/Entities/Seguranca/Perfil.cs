using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    [DataContract]
    public class Perfil: IPerfil
    {
        #region Implementation of IPerfil

        [DataMember]
        public string Nome{get; set; }

        [DataMember]
        public long? PerfilId{get; set; }

        #endregion
    }
}
