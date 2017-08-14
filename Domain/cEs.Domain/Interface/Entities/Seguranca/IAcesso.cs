using cEs.Domain.Entities.Administrativo;
using cEs.Domain.Entities.Seguranca;
using System.Collections.Generic;

namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IAcesso
    {
        long? AcessoId { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        bool Ativo { get; set; }
        long? PerfilTipoId { get; set; }
        long? UsuarioId { get; set; }
        long? EmpresaId { get; set; }
        string Empresa { get; set; }
        string Email { get; set; }
        string CelularDDD { get; set; }
        string CelularNumero { get; set; }
        string Nome { get; set; }
        string AspNetUser { get; set; }

    }
}
