using cEs.Application.Interface.Comercial;
using cEs.Domain.Interface.Repositories.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;

namespace cEs.Application.Comercial
{
    public class SolicitacaoAppService: ISolicitacaoAppService
    {
        private readonly ISolicitacaoRepository _solicitacaoRepository;

        public SolicitacaoAppService(ISolicitacaoRepository solicitacaoRepository)
        {
            _solicitacaoRepository = solicitacaoRepository;
        }

        public bool Delete(Solicitacao obj)
        {
            return _solicitacaoRepository.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Solicitacao Find(Solicitacao obj)
        {
            return _solicitacaoRepository.Find(obj);
        }

        public long? Insert(Solicitacao obj)
        {
            return _solicitacaoRepository.Insert(obj);
        }

        public List<Solicitacao> Lista(Solicitacao obj)
        {
            return _solicitacaoRepository.Lista(obj);
        }

        public List<Solicitacao> Search(Solicitacao obj)
        {
            return _solicitacaoRepository.Search(obj);
        }

        public bool Update(Solicitacao obj)
        {
            return _solicitacaoRepository.Update(obj);
        }

    }
}
