using pNc.Application.Interface.Administrativo;
using System;
using System.Collections.Generic;
using pNc.Application.wcf.Administrativo.Situacao;

namespace pNc.Application.Administrativo
{
    public class SituacaoAppService: ISituacaoAppService
    {
        private readonly SituacaoClient _wcf;

        public SituacaoAppService()
        {
            _wcf = new SituacaoClient();
        }

        public bool Delete(Domain.Entities.Administrativo.Situacao obj)
        {
            return _wcf.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Administrativo.Situacao Find(Domain.Entities.Administrativo.Situacao obj)
        {
            return _wcf.Find(obj);
        }

        public long? Insert(Domain.Entities.Administrativo.Situacao obj)
        {
            return _wcf.Insert(obj);
        }

        public List<Domain.Entities.Administrativo.Situacao> Search(Domain.Entities.Administrativo.Situacao obj)
        {
            return _wcf.Search(obj);
        }

        public bool Update(Domain.Entities.Administrativo.Situacao obj)
        {
            return _wcf.Update(obj);
        }
    }
}
