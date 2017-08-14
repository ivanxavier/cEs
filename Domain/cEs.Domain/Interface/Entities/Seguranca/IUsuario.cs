namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IUsuario
    {
        long? UsuarioId { get; set; }
        string Nome { get; set; }
        string TelefoneDDD { get; set; }
        string TelefoneNumero { get; set; }
        string Email { get; set; }
    }
}
