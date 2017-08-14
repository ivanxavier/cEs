using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Domain.Interface.Entities.Comercial
{
    public interface ISolicitacaoDataHorario
    {
     long? SolicitacaoDataHorarioId { get; set; }
     string Inicio { get; set; }
     string Termino { get; set; }
     long? SolicitacaoDataId { get; set; }
    }
}
