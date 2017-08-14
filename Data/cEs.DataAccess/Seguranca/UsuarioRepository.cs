using System;
using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;

namespace cEs.DataAccess.Seguranca
{
    public class UsuarioRepository: IUsuarioRepository
    {
        #region Implementation of IRepositoryBase<Usuario>

        public long? Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario Find(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Search(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
