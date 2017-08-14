using cEs.Domain.Interface.Entities.Comercial;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cEs.Portal.Models.Comercial
{
    public class SolicitacaoViewModel : ISolicitacao
    {
        public long? SolicitacaoId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Contato { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Procurar { get; set; }
        public DateTime? Data { get; set; }
        public string SolicitacaoStatusId { get; set; }
    }
    public class SolicitacaoListaViewModel
    {
        public long? SolicitacaoId { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data")]
        public DateTime? Data { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
