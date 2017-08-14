using cEs.Application.Interface;
using cEs.Domain.Interface.Services;
using System;
using System.Collections.Generic;

namespace cEs.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {

        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public long? Insert(TEntity obj)
        {
            return _serviceBase.Insert(obj);
        }

        public TEntity Find(TEntity obj)
        {
            return _serviceBase.Find(obj);
        }

        public List<TEntity> Search(TEntity obj)
        {
            return _serviceBase.Search(obj);
        }

        public bool Update(TEntity obj)
        {
            return _serviceBase.Update(obj);
        }

        public bool Delete(TEntity obj)
        {
            return _serviceBase.Delete(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
