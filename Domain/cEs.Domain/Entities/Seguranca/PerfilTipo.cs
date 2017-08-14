using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    public class PerfilTipo : IPerfilTipo
    {
        public long? PerfilId { get; set; }
        public string Perfil { get; set; }
        public long? PerfilTipoId { get; set; }
        public long? UsuarioTipoId { get; set; }
        public string UsuarioTipo { get; set; }
    }
}
