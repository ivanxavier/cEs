using System;
using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    [DataContract]
    public class PaginaMenu : IPaginaMenu
    {
        #region Implementation of IPaginaMenu
        [DataMember]
        public long? MenuId { get; set; }
        [DataMember]
        public string Menu { get; set; }
        [DataMember]
        public long? PaginaId { get; set; }
        [DataMember]
        public string Pagina { get; set; }
        [DataMember]
        public long? AcessoId { get; set; }
        [DataMember]
        public long? PaginaMenuId { get; set; }
        [DataMember]
        public string Action { get; set; }
        [DataMember]
        public string Controller { get; set; }
        [DataMember]
        public long? PaginaIdPai { get; set; }
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public string PaginaPai { get; set; }
        #endregion
    }
}
