using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Services.Seguranca
{
    public interface IPaginaService: IServiceBase<Pagina>
    {
        List<Pagina> UsuarioPagina(Acesso obj, Menu objMenu);
    }
}
