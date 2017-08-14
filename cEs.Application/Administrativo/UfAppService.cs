using cEs.Application.Interface.Administrativo;
using cEs.Domain.Interface.Repositories.Administrativo;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Administrativo;

namespace cEs.Application.Administrativo
{
    public class UfAppService: IUfAppService
    {
        private readonly IUfRepository _ufRepository;

        public UfAppService(IUfRepository UfRepository)
        {
            _ufRepository = UfRepository;
        }

        public bool Delete(Uf obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Uf Find(Uf obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(Uf obj)
        {
            throw new NotImplementedException();
        }

        public List<Uf> Search(Uf obj)
        {
            return _ufRepository.Search(obj);
        }

        public bool Update(Uf obj)
        {
            throw new NotImplementedException();
        }


        //public bool Delete(Uf obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public Uf Find(Uf obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public long? Insert(Uf obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Uf> Search(Uf obj)
        //{
        //    return _ufRepository.Search(obj);
        //}

        //public bool Update(Uf obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
