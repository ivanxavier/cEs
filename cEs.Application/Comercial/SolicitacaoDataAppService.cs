using cEs.Application.Interface.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using cEs.Domain.Interface.Repositories.Comercial;

namespace cEs.Application.Comercial
{
    public class SolicitacaoDataAppService : ISolicitacaoDataAppService
    {
        private readonly ISolicitacaoDataRepository _solicitacaoDataRepository;

        public SolicitacaoDataAppService(ISolicitacaoDataRepository SolicitacaoDataRepository)
        {
            _solicitacaoDataRepository = SolicitacaoDataRepository;
        }

        public bool Delete(SolicitacaoData obj)
        {
            return _solicitacaoDataRepository.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SolicitacaoData Find(SolicitacaoData obj)
        {
            return _solicitacaoDataRepository.Find(obj);
        }

        public long? Insert(SolicitacaoData obj)
        {
            return _solicitacaoDataRepository.Insert(obj);
        }

        public List<SolicitacaoData> Search(SolicitacaoData obj)
        {
            return _solicitacaoDataRepository.Search(obj);
        }

        public bool Update(SolicitacaoData obj)
        {
            return _solicitacaoDataRepository.Update(obj);
        }

    }
}
