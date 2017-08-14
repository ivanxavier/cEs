using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Services.Seguranca
{
    public interface IPaginaPerfilService: IServiceBase<PaginaPerfil >
    {
        List<PaginaPerfilDisponivel> ListarDisponivel(PaginaPerfil obj);
    }
}
