using cEs.Application.Interface.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Seguranca;

namespace cEs.Application.Seguranca
{
    public class PaginaMenuAppService: IPaginaMenuAppService
    {
        private readonly IPaginaMenuRepository _paginaMenuRepository;

        public PaginaMenuAppService(IPaginaMenuRepository paginaMenuRepository)
        {
            _paginaMenuRepository = paginaMenuRepository;
        }

        public bool Delete(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public PaginaMenu Find(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public List<PaginaMenuDisponivel> ListarDisponivel(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public List<PaginaMenu> Pesquisa(PaginaMenu obj)
        {
            return _paginaMenuRepository.Pesquisa(obj);
        }

        public List<PaginaMenu> Search(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }
    }


}
