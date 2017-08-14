using cEs.Domain.Entities.Administrativo;

namespace cEs.Domain.Interface.Services.Administrativo
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        Endereco BuscaCep(Endereco obj);
    }
}
