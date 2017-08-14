using cEs.Domain.Entities.Administrativo;

namespace cEs.Domain.Interface.Repositories.Administrativo
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        Endereco BuscaCep(Endereco obj);
    }   
}
