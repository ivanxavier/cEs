using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cEs.Portal.Models.Seguranca.PaginaMenuModel
{
    public class PaginaMenuItemListModel
    {
        public List<PaginaMenuItemModel> PaginaMenuItems { get; set; }
        public PaginaMenuItemListModel()
        {
            PaginaMenuItems = new List<PaginaMenuItemModel>();
        }
    }
}
