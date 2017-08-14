using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Services.Seguranca
{
    public interface IPaginaMenuService : IServiceBase<PaginaMenu>
    {
        List<PaginaMenuDisponivel> ListarDisponivel(PaginaMenu obj);
        List<PaginaMenu> Pesquisa(PaginaMenu obj);
    }
}
