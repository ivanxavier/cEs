namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IPaginaPerfil
    {
        long? MenuId { get; set; }
        string MenuNome { get; set; }
        long? PaginaId { get; set; }
        string PaginaNome { get; set; }
        long? PaginaPerfilId { get; set; }
        long? PerfilId { get; set; }
        string PerfilNome { get; set; }
        long? AcessoId { get; set; }
    }
}
