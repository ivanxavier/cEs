using cEs.Application.Seguranca;
using cEs.Domain.Entities.Seguranca;
using cEs.Infra.Authentication.Class;
using cEs.Portal.Models.Seguranca.PaginaMenuModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace cEs.Portal.MenuHelpers
{
    public class MenuPesquisa : Controller
    {
        public PaginaMenuItemListModel MenuList { get; set; }
        PaginaMenuAppService _paginaMenuAppService;
        AcessoAppService _acessoApp;
        private readonly IHttpContextAccessor _accessor;


        public MenuPesquisa(PaginaMenuAppService paginaMenuAppService, AcessoAppService AcessoApp, IHttpContextAccessor accessor)
        {
            _paginaMenuAppService = paginaMenuAppService;
            _accessor = accessor;
            _acessoApp = AcessoApp;
        }

        public Task<PaginaMenuItemListModel> GetMenus()
        {
            var _Acessor = _accessor.HttpContext.User.getUserId();
            var _acesso = _acessoApp.Login(new Acesso { AspNetUser = _Acessor });
            PaginaMenuItemListModel model = new PaginaMenuItemListModel();
            long? _acessoId = null;
            MenuList = new PaginaMenuItemListModel();
            foreach (var y in _acesso)
            {
                _acessoId = y.AcessoId;
            };

            var _menu = _paginaMenuAppService.Pesquisa(new PaginaMenu() { AcessoId = _acessoId });

            foreach (var e in _menu)
            {
                MenuList.PaginaMenuItems.Add(new PaginaMenuItemModel(e.PaginaId, e.PaginaIdPai, e.Pagina, e.PaginaPai, e.AcessoId, e.PaginaMenuId, e.Action, e.Controller, e.Tipo));
            };
            return Task.FromResult<PaginaMenuItemListModel>(MenuList);
        }
    }
}
