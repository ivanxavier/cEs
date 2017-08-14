using cEs.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Domain.Interface.Repositories.Comercial
{
    public interface ISolicitacaoRepository : IRepositoryBase<Solicitacao>
    {
        List<Solicitacao> Lista(Solicitacao obj);
    }
}
