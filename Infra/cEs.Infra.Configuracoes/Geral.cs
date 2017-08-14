using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;

namespace cEs.Infra.Configuracoes
{
    public class Geral : DbContext
    {
        public class DbConexao
        {
            public string Owner { get; set; }

            public string DefaultConnection { get; set; }
        }

        public class TelefoneFormat
        {
            public static string formatPhoneNumber(string phoneNum, string tipo)
            {
                string formato = "";
                if (tipo == "F")
                {
                    formato = "(##) ####-####";
                }
                else if (tipo == "C")
                {
                    formato = "(##) #####-####";
                }

                // First, remove everything except of numbers
                Regex regexObj = new Regex(@"[^\d]");
                phoneNum = regexObj.Replace(phoneNum, "");

                // Second, format numbers to phone string
                if (phoneNum.Length > 0)
                {
                    phoneNum = Convert.ToInt64(phoneNum).ToString(formato);
                }

                 return phoneNum;
            }
        }

    }

}
