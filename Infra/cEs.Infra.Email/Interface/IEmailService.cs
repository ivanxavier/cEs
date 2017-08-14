using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cEs.Infra.Email.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(string Nome, string email, string subject, string message);
        Task SendEmailRespostaAsync(string email, string subject, string message);
    }
}
