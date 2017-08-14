using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Services.Seguranca
{
    public interface IMenuService: IServiceBase<Menu>
    {
        List<Menu> UsuarioMenu(Acesso obj);
    }
}
