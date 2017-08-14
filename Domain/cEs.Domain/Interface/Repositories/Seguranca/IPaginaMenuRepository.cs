﻿using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Repositories.Seguranca
{
    public interface IPaginaMenuRepository : IRepositoryBase<PaginaMenu>
    {
        List<PaginaMenuDisponivel> ListarDisponivel(PaginaMenu obj);
        List<PaginaMenu> Pesquisa(PaginaMenu obj);
     
    }
}
