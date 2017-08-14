using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Entities.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cEs.Portal.Models.Seguranca.PaginaMenuModel
{
    public class PaginaMenuItemModel : PaginaMenu
    {
        public long Id { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string MenuItemText { get; set; }
        public string Title { get; set; }
        public long ParentId { get; set; }
        public string Tipo { get; set; }

        public PaginaMenuItemModel()
        {

        }

        public PaginaMenuItemModel(long? paginaId, long? paginaIdPai, string pagina, string paginaPai, long? acessoId, long? paginaMenuId, string action, string controller, string tipo)
        {
            //MenuId = unchecked((int)paginaId);

            Id = unchecked((int)paginaId);
            MenuItemText = pagina;
            ActionName = action;
            ControllerName = controller;
            Title = pagina;
            ParentId = unchecked((int)paginaIdPai);
            Tipo = tipo;
        }

    }
}
