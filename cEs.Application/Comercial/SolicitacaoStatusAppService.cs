using cEs.Application.Interface.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using cEs.Domain.Interface.Repositories.Comercial;

namespace cEs.Application.Comercial
{
    public class SolicitacaoStatusAppService : ISolicitacaoStatusAppService
    {
        private readonly ISolicitacaoStatusRepository _solicitacaoStatusRepository;

        public SolicitacaoStatusAppService(ISolicitacaoStatusRepository SolicitacaoStatusRepository)
        {
            _solicitacaoStatusRepository = SolicitacaoStatusRepository;
        }

        public bool Delete(SolicitacaoStatus obj)
        {
            return _solicitacaoStatusRepository.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SolicitacaoStatus Find(SolicitacaoStatus obj)
        {
            return _solicitacaoStatusRepository.Find(obj);
        }

        public long? Insert(SolicitacaoStatus obj)
        {
            return _solicitacaoStatusRepository.Insert(obj);
        }

        public List<SolicitacaoStatus> Search(SolicitacaoStatus obj)
        {
            return _solicitacaoStatusRepository.Search(obj);
        }

        public bool Update(SolicitacaoStatus obj)
        {
            return _solicitacaoStatusRepository.Update(obj);
        }
    }
}
