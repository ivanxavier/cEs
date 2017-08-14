using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cEs.Portal.Models.Seguranca.ContaUsuario
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Remember me?")]
        public bool LembreMe { get; set; }
    }
}
