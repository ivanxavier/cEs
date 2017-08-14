using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        Int64? Insert(TEntity obj);
        TEntity Find(TEntity obj);
        List<TEntity> Search(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(TEntity obj);
        void Dispose();
    }
}
