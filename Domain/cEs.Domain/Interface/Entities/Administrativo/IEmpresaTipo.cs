using System;

namespace cEs.Domain.Interface.Entities.Administrativo
{
    public interface IEmpresaTipo
    {
        Int64? EmpresaTipoId { get; set; }
        string Nome { get; set; }
    }
}