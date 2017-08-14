using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cEs.Domain.Interface.Entities
{
    public interface IBaseMovimentoDb
    {
        DateTime? AlteracaoData { get; set; }
        long? AlteracaoUsuario { get; set; }
        DateTime InclusaoData { get; set; }
        long InclusaoUsuario { get; set; }
    }
}
