using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Domain.Interface.Entities.Administrativo
{
    public interface IParametroHorario
    {
     long? ParametroHorarioId { get; set; }
     string Horario { get; set; }
    }
}
