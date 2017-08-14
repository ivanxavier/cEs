namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IPaginaMenu
    {
        long? MenuId { get; set; }
        string Menu { get; set; }
        long? PaginaId { get; set; }
        long? PaginaIdPai { get; set; }
        string Pagina { get; set; }
        long? AcessoId { get; set; }
        long? PaginaMenuId { get; set; }
        string Action { get; set; }
        string Controller { get; set; }
        string Tipo { get; set; }
        string PaginaPai { get; set; }
    }
}
