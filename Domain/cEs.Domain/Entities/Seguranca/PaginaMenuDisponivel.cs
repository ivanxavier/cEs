using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    public class PaginaMenuDisponivel: IPaginaMenuDisponivel
    {
        #region Implementation of IPaginaMenuDisponivel

        public bool Disponivel { get; set; }
        #endregion
    }
}
