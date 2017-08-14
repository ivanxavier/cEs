namespace cEs.Domain.Interface.Entities.Comercial
{
    public interface IContato
    {
        long? ContatoId { get; set; }
        string Nome { get; set; }
        string Telefone { get; set; }
        string Mensagem { get; set; }
        string Email { get; set; }
        string Celular { get; set; }
        bool Status { get; set; }
    }
}