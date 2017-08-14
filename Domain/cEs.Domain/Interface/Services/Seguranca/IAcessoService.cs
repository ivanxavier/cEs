using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Domain.Interface.Services.Seguranca
{
    public interface IAcessoService : IServiceBase<Acesso>
    {
        List<Acesso> Login(Acesso obj);
    }
}
