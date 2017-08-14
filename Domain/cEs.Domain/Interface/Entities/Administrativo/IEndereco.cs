namespace cEs.Domain.Interface.Entities.Administrativo
{
    public interface IEndereco
    {
        string Cep { get; set; }
        string Logradouro { get; set; }
        string Numero { get; set; }
        string Bairro { get; set; }
        string Municipio { get; set; }
        string Estado { get; set; }
        string Complemento { get; set; }
    }
}
