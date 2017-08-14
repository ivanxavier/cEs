using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cEs.Domain.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Int64? Insert(TEntity obj);
        TEntity Find(TEntity obj);
        List<TEntity> Search(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(TEntity obj);
        void Dispose();
    }
    public interface IServiceAppBase<TEntity> where TEntity : class
    {
        Int64? Insert(TEntity obj);
        TEntity Find(TEntity obj);
        List<TEntity> Search(TEntity obj);
        bool Update(TEntity obj); 
        bool Delete(TEntity obj);
        void Dispose();


    }
}
