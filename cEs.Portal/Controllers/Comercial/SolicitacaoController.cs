using cEs.Application.Administrativo;
using cEs.Application.Comercial;
using cEs.Portal.Models.Comercial;
using cEs.Domain.Entities.Comercial;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using cEs.Domain.Entities.Administrativo;
using System.Threading.Tasks;

namespace cEs.Portal.Controllers.Comercial
{
    public class SolicitacaoController : Controller
    {
        private readonly SolicitacaoAppService _solicitacaoApp;
        private readonly UfAppService _ufApp;
        private readonly SolicitacaoStatusAppService _solicitacaoStatusApp;
        public SolicitacaoController(SolicitacaoAppService SolicitacaoApp, UfAppService UfApp, SolicitacaoStatusAppService SolicitacaoStatusApp)
        {
            _solicitacaoApp = SolicitacaoApp;
            _ufApp = UfApp;
            _solicitacaoStatusApp = SolicitacaoStatusApp;
        }
        public ActionResult Index()
        {
            var Lista = _solicitacaoApp.Lista(new Solicitacao());
            var _lista = new List<SolicitacaoListaViewModel>();
            var lista = new SolicitacaoListaViewModel();
            foreach (var item in Lista)
            {
                lista.Nome = item.Nome;
                lista.SolicitacaoId = item.SolicitacaoId;
                lista.Data = item.Data;
                lista.Status = item.Status;
                _lista.Add(lista);
            }


            return View("~/Views/Comercial/Solicitacao/Index.cshtml", _solicitacaoApp.Lista(new Solicitacao()).ToList());
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Insert(cEs.Domain.Entities.Comercial.Solicitacao model)
        //{
        //    try
        //    {
        //        var _solicitacao = _solicitacaoApp.Insert(model);
        //    }
        //    catch (Exception ex)
        //    {
        //        string mensagem = ex.Message;
        //        return null;
        //        //new JsonResult() { Data = new { Sucesso = "0", Mensagem = mensagem }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //    }
        //    return RedirectToAction("Insert", "Solicitacao");

        //}
        public ActionResult Insert()
        {
            ViewData["Estados"] = _ufApp.Search(new Uf());
            ViewData["Status"] = _solicitacaoStatusApp.Search(new SolicitacaoStatus());
            return View("~/Views/Comercial/Solicitacao/Insert.cshtml");
        }

        public async Task<IActionResult> Salvar(SolicitacaoViewModel model)
        {
            var Index = _solicitacaoApp.Insert(new Solicitacao() {
                Nome = model.Nome,
                Celular = model.Celular,
                Telefone = model.Telefone,
                Email = model.Email,
                Endereco = model.Endereco,
                Numero = model.Numero,
                Bairro = model.Bairro,
                Municipio = model.Municipio,
                UF = model.UF,
                Cep = model.Cep,
                Contato = model.Contato,
                SolicitacaoStatusId = model.SolicitacaoStatusId,
                Assunto = model.Assunto,
            });
            return Json(Index);
        }


    }
}
