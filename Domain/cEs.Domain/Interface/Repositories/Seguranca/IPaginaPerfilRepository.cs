using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Repositories.Seguranca
{
    public interface IPaginaPerfilRepository : IRepositoryBase<PaginaPerfil>
    {
        List<PaginaPerfilDisponivel> ListarDisponivel(PaginaPerfil obj);
    }
}
