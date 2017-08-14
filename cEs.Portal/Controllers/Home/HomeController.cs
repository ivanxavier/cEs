using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using cEs.Infra.Authentication.DataModel;
using cEs.Application.Seguranca;
using cEs.Domain.Entities.Seguranca;
using Microsoft.AspNetCore.Http.Authentication;
using System.Threading.Tasks;

namespace cEs.Portal.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
