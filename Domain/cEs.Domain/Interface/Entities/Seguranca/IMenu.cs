using System;

namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IMenu
    {
        long? MenuId { get; set; }
        string Nome { get; set; }
        string Icone { get; set; }
        Int32? Ordem { get; set; }
    }
}
