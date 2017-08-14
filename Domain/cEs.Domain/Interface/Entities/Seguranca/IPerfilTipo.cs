namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IPerfilTipo
    {
        long? PerfilId { get; set; }
        string Perfil { get; set; }
        long? PerfilTipoId { get; set; }
        long? UsuarioTipoId { get; set; }
        string UsuarioTipo { get; set; }
    }
}
