using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Domain.Interface.Entities.Comercial
{
    public interface ISolicitacaoData
    {
        long? SolicitacaoDataId {get; set;}
        DateTime Data { get; set; }
    
        long? SolicitacaoId { get; set; }
    }
}
