using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    [DataContract]
    public class Menu: IMenu
    {
        #region Implementation of IMenu

        [DataMember]
        public long? MenuId { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Icone { get; set; }

        [DataMember]
        public int? Ordem { get; set; }
        #endregion
    }
}
