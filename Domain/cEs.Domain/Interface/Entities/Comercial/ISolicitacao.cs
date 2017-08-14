using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Domain.Interface.Entities.Comercial
{
    public interface ISolicitacao
    {
        long? SolicitacaoId { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }
        Int32? Numero { get; set; }
        string Complemento { get; set; }
        string Bairro { get; set; }
        string Municipio { get; set; }
        string UF { get; set; }
        string Cep { get; set; }
        string Contato { get; set; }
        string Celular { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }
        string Assunto { get; set; }
        string Procurar { get; set; }
        string SolicitacaoStatusId { get; set; }

        DateTime? Data { get; set; }
    }
}
