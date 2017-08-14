using cEs.Domain.Interface.Entities.Administrativo;
using System.Runtime.Serialization;

namespace cEs.Domain.Entities.Administrativo
{
    [DataContract]
    public class Empresa: IEmpresa
    {
        #region Implementation of IEmpresa

        [DataMember]
        public long EmpresaId { get; set; }
        [DataMember]
        public string Nome { get; set; }

        #endregion
    }
}
