using cEs.Domain.Interface.Entities.Comercial;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cEs.Portal.Models.Comercial
{
    public class ContatoViewModel : IContato
    {
        public long? ContatoId { get; set; }
        public string Nome { get; set; }
        //[DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:(99) 9999-9999}", ApplyFormatInEditMode = true)]
        public string Telefone { get; set; }
        public string Mensagem { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Você deve fornecer um número de Celular")]
        //[Display(Name = "Celular")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{(99) 99999-9999}")]

[Required(ErrorMessage = "Your must provide a PhoneNumber")]
[Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        //public string PhoneNumber { get; set; }
        public string Celular { get; set; }
        public bool Status { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The BirthDate is Required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Birth Date")]
        public DateTime ReleaseDate1 { get; set; }


    }
}
