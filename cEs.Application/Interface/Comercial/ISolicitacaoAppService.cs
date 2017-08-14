﻿using cEs.Domain.Entities.Comercial;
using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Application.Interface.Comercial
{
    public interface ISolicitacaoAppService : IAppServiceBase<Solicitacao>
    {
        List<Solicitacao> Lista(Solicitacao obj);
    }
}
