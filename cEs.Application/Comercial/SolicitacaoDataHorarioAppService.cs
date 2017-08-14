using cEs.Application.Interface.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using cEs.Domain.Interface.Repositories.Comercial;

namespace cEs.Application.Comercial
{
    public class SolicitacaoDataHorarioAppService : ISolicitacaoDataHorarioAppService
    {
        private readonly ISolicitacaoDataHorarioRepository _solicitacaoDataHorarioRepository;

        public SolicitacaoDataHorarioAppService(ISolicitacaoDataHorarioRepository SolicitacaoDataHorarioRepository)
        {
            _solicitacaoDataHorarioRepository = SolicitacaoDataHorarioRepository;
        }

        public bool Delete(SolicitacaoDataHorario obj)
        {
            return _solicitacaoDataHorarioRepository.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SolicitacaoDataHorario Find(SolicitacaoDataHorario obj)
        {
            return _solicitacaoDataHorarioRepository.Find(obj);
        }

        public long? Insert(SolicitacaoDataHorario obj)
        {
            return _solicitacaoDataHorarioRepository.Insert(obj);
        }

        public List<SolicitacaoDataHorario> Search(SolicitacaoDataHorario obj)
        {
            return _solicitacaoDataHorarioRepository.Search(obj);
        }

        public bool Update(SolicitacaoDataHorario obj)
        {
            return _solicitacaoDataHorarioRepository.Update(obj);
        }
    }
}
