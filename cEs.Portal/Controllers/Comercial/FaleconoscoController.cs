using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cEs.Application.Comercial;
using cEs.Infra.Email.Interface;
using Microsoft.AspNetCore.Authorization;
using cEs.Domain.Entities.Comercial;
using cEs.Portal.Models.Comercial;

namespace cEs.Portal.Controllers.Comercial
{
    public class FaleconoscoController : Controller
    {
        private readonly ContatoAppService _contatoApp;
        private readonly IEmailService _emailService;
        public FaleconoscoController(ContatoAppService ContatoApp, IEmailService emailService)
        {
            _contatoApp = ContatoApp;
            _emailService = emailService;
        }


        [AllowAnonymous]
        public ActionResult Index()
        {
            //TempData["mensagem"] = null;
            return View("~/Views/Comercial/Faleconosco/Index.cshtml");
            //return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //[ChildActionOnly]
        //public async Task<IActionResult> Index(ContatoViewModel model)
        //{
        //    var _reg = new ContatoViewModel();
        //    if (ModelState.IsValid)
        //    {
        //        var Index = _contatoApp.Insert(new Contato() { Nome = model.Nome, Celular = model.Celular, Telefone = model.Telefone, Email = model.Email, Mensagem = model.Mensagem, Status = true });
        //        await _emailService.SendEmailAsync(model.Nome, model.Email, "Fale Conosco", model.Mensagem + "<br/><br/>" + model.Nome + "<br/>" + String.Format(@"{0:\(00\)00000\-0000}", model.Celular) + "<br/>" + String.Format(@"{0:\(00\)0000\-0000}", model.Telefone));
        //        await _emailService.SendEmailRespostaAsync(model.Email, "Agradecimento", "Construtora e Empreiteira Sistemplam Ltda<br/><br/>Obrigado pelo seu e-mail<br/><br/>Alguém irá entrar em contato<br/><br/><br/>Grato");
        //        _reg.ContatoId = Index;
        //    }
        //    return Json(_reg.Celular);
        //    //return View("~/Views/Comercial/Faleconosco/Index.cshtml", _reg);
        //}

        [AllowAnonymous]
        public ActionResult Volta()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [AllowAnonymous]
        public ActionResult Fecha()
        {
            return View("~/Views/Comercial/Faleconosco/Fecha.cshtml");
        }

        public async Task<IActionResult> Salvar(ContatoViewModel model)
        {
            var Index = _contatoApp.Insert(new Contato() { Nome = model.Nome, Celular = model.Celular, Telefone = model.Telefone, Email = model.Email, Mensagem = model.Mensagem, Status = true });
            await _emailService.SendEmailAsync(model.Nome, model.Email, "Fale Conosco", model.Mensagem + "<br/><br/>" + model.Nome + "<br/>" + String.Format(@"{0:\(00\)00000\-0000}", model.Celular) + "<br/>" + String.Format(@"{0:\(00\)0000\-0000}", model.Telefone));
            await _emailService.SendEmailRespostaAsync(model.Email, "Agradecimento", "Construtora e Empreiteira Sistemplam Ltda<br/><br/>Obrigado pelo seu e-mail<br/><br/>Alguém irá entrar em contato<br/><br/><br/>Grato");
            return Json(Index);
        }

    }
}