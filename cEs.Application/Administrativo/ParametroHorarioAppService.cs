using cEs.Application.Interface.Administrativo;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Administrativo;
using cEs.Domain.Interface.Repositories.Administrativo;

namespace cEs.Application.Administrativo
{
    public class ParametroHorarioAppService : IParametroHorarioAppService
    {
        private readonly IParametroHorarioRepository _parametroHorarioRepository;

        public ParametroHorarioAppService(IParametroHorarioRepository ParametroHorarioRepository)
        {
            _parametroHorarioRepository = ParametroHorarioRepository;
        }

        public bool Delete(ParametroHorario obj)
        {
            return _parametroHorarioRepository.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ParametroHorario Find(ParametroHorario obj)
        {
            return _parametroHorarioRepository.Find(obj);
        }

        public long? Insert(ParametroHorario obj)
        {
            return _parametroHorarioRepository.Insert(obj);
        }

        public List<ParametroHorario> Search(ParametroHorario obj)
        {
            return _parametroHorarioRepository.Search(obj);
        }

        public bool Update(ParametroHorario obj)
        {
            return _parametroHorarioRepository.Update(obj);
        }
    }
}
