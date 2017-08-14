using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Repositories.Seguranca
{
    public interface IAcessoRepository : IRepositoryBase<Acesso>
    {
        List<Acesso> Login(Acesso obj);
    }
}
