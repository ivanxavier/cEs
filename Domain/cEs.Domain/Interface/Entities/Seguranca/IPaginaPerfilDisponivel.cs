namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IPaginaPerfilDisponivel: IPaginaPerfil
    {
        bool Disponivel { get; set; }
    }
}
