using System;

namespace cEs.Domain.Interface.Entities.Administrativo
{
    public interface IEmpresa
    {
        Int64 EmpresaId { get; set; }
        string Nome { get; set; }
    }
}
