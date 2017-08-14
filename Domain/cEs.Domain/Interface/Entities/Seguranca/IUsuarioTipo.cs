namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IUsuarioTipo
    {
        string Nome { get; set; }
        bool Relacionado { get; set; }
        long? UsuarioTipoId { get; set; }
        bool? Administrador { get; set; }
        bool? Representante { get; set; }
        bool? Workflow { get; set; }
        bool? PublicoAlvo { get; set; }
    }
}
