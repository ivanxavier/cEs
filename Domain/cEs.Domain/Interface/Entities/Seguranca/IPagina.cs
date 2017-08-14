using System;

namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IPagina
    {
        string Icone { get; set; }
        string Nome { get; set; }
        long? PaginaId { get; set; }
        string Url { get; set; }
        long? AcessoId { get; set; }
        Int32? Ordem { get; set; }
        string Action { get; set; }
        string Controller { get; set; }
    }
}
