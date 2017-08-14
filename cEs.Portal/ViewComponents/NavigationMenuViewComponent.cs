using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cEs.Portal.Models;
using cEs.Portal.MenuHelpers;
using cEs.Domain.Interface.Entities.Seguranca;
using cEs.Portal.Models.Seguranca.PaginaMenuModel;

namespace cEs.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        //private readonly IUser _logado;
        MenuPesquisa _paginaMenuPesquisa;
        public NavigationMenuViewComponent(MenuPesquisa paginaMenuPesquisa/*, IUser logado*/)
        {
            //_logado = logado;
            _paginaMenuPesquisa = paginaMenuPesquisa;
        }

        //public IViewComponentResult Invoke()
        //{
        //    MenuItemListModel model = _menuDataRepository.GetMenus();
        //    return View(model);
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            PaginaMenuItemListModel model = await _paginaMenuPesquisa.GetMenus();
            return View(model);
        }
    }
}
