using System;
using System.Collections.Generic;
using cEs.Domain.Interface.Repositories;
using cEs.Infra.Configuracoes.Data;
using Microsoft.EntityFrameworkCore;

namespace cEs.DataAccess
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class 
    {
        protected ApplicationDbContext Db;
        protected DbSet<TEntity> DbSet;

        public RepositoryBase(ApplicationDbContext conexao)
        {
            Db = conexao;
            DbSet = Db.Set<TEntity>();
        }
        public long? Insert(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Search(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
