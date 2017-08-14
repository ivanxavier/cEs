using cEs.Application.Interface.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using cEs.Domain.Interface.Repositories.Comercial;

namespace cEs.Application.Comercial
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoAppService(IContatoRepository paginaMenuRepository)
        {
            _contatoRepository = paginaMenuRepository;
        }
        public bool Delete(Contato obj)
        {
            return _contatoRepository.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Contato Find(Contato obj)
        {
            return _contatoRepository.Find(obj);
        }

        public long? Insert(Contato obj)
        {
            return _contatoRepository.Insert(obj);
        }


        public List<Contato> Search(Contato obj)
        {
            return _contatoRepository.Search(obj);
        }

        public bool Update(Contato obj)
        {
            return _contatoRepository.Update(obj);
        }
    }
}
