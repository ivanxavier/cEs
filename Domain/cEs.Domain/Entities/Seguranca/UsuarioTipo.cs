using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    [DataContract]
    public class UsuarioTipo: IUsuarioTipo
    {
        #region Implementation of IUsuarioTipo

        [DataMember]
        public string Nome{get ; set ;}

        [DataMember]
        public bool Relacionado{get ; set ;}

        [DataMember]
        public long? UsuarioTipoId{get ; set ;}

        [DataMember]
        public bool? Administrador{get ; set ;}

        [DataMember]
        public bool? Representante{get ; set ;}

        [DataMember]
        public bool? Workflow{get ; set ;}

        [DataMember]
        public bool? PublicoAlvo{get ; set ;}

        #endregion
    }
}
