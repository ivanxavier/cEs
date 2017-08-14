using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Repositories.Seguranca
{
    public interface IPaginaRepository : IRepositoryBase<Pagina>
    {
        List<Pagina> UsuarioPagina(Acesso obj, Menu objMenu);
    }
}
