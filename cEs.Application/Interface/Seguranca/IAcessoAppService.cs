using System.Collections.Generic;
using cEs.Application.Interface;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Application.Interface
{
    public interface IAcessoAppService : IAppServiceBase<Acesso>
    {
        List<Acesso> Login(Acesso obj);
    }
}
