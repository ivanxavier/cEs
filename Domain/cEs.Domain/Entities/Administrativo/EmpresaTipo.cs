using cEs.Domain.Interface.Entities.Administrativo;

namespace cEs.Domain.Entities.Administrativo
{
    public class EmpresaTipo : IEmpresaTipo
    {
        public long? EmpresaTipoId { get; set; }
        public string Nome { get; set; }
    }
}