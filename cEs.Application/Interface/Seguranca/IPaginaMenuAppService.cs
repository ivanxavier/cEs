using cEs.Domain.Entities.Seguranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Application.Interface.Seguranca
{
    public interface IPaginaMenuAppService: IAppServiceBase<PaginaMenu>
    {
        List<PaginaMenuDisponivel> ListarDisponivel(PaginaMenu obj);
        List<PaginaMenu> Pesquisa(PaginaMenu obj);
    }
}
