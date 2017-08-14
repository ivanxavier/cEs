using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Repositories.Seguranca
{
    public interface IMenuRepository : IRepositoryBase<Menu>
    {
        List<Menu> UsuarioMenu(Acesso obj);
        
    }
}
