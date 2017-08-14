using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{

    [DataContract]
    public class Pagina: IPagina
    {
        #region Implementation of IPagina

        [DataMember]
        public string Icone { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public long? PaginaId { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public long? AcessoId { get; set; }

        [DataMember]
        public int? Ordem { get; set; }

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public string Controller { get; set; }

        #endregion
    }
}
