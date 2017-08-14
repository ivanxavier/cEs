using System;
using System.Collections.Generic;

namespace cEs.Domain.Interface.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        Int64? Insert(TEntity obj);
        TEntity Find(TEntity obj);
        List<TEntity> Search(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(TEntity obj);
        void Dispose();
    }
} 