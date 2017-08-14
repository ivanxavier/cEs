using cEs.Application.Interface;
using System;
using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;

namespace cEs.Application.Seguranca
{
    public class AcessoAppService : IAcessoAppService
    {
        private readonly IAcessoRepository _acessoRepository;

        public AcessoAppService(IAcessoRepository acessoRepository)
        {
            _acessoRepository = acessoRepository;
        }

        public bool Delete(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Acesso Find(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public List<Acesso> Login(Acesso obj)
        {
            return _acessoRepository.Login(obj);
        }

        public List<Acesso> Search(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Acesso obj)
        {
            throw new NotImplementedException();
        }
    }
}
