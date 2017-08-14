using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cEs.Application.Comercial;
using Microsoft.AspNetCore.Authorization;
using cEs.Domain.Entities.Comercial;
using cEs.Infra.Email.Interface;

namespace cEs.Portal.Controllers.Comercial
{
    public class ComercialController : Controller
    {
        private readonly ContatoAppService _contatoApp;
        private readonly IEmailService _emailService;
        public ComercialController(ContatoAppService ContatoApp, IEmailService emailService)
        {
            _contatoApp = ContatoApp;
            _emailService = emailService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult Faleconosco()
        {
            return View();
        }



        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Faleconosco(Contato model)
        {


            if (ModelState.IsValid)
            {
                var Index = _contatoApp.Insert(new Contato() { Nome = model.Nome, Celular = model.Celular, Telefone = model.Telefone, Email = model.Email, Mensagem = model.Mensagem, Status = true });
                await _emailService.SendEmailAsync(model.Nome, model.Email, "Fale Conosco", model.Mensagem);
                ViewBag.Succes = true;
            }
            return View(model);
        }
    }
}