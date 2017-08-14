using System;
using System.Collections.Generic;
using pNc.Application.Interface.Administrativo;
using pNc.Application.wcf.Administrativo.Cliente;
using pNc.Domain.Entities.Administrativo;

namespace pNc.Application.Administrativo
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteClient _wcf;

        public ClienteAppService()
        {
            _wcf = new ClienteClient();
        }

        public bool Delete(Domain.Entities.Administrativo.Cliente obj)
        {
            return _wcf.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Administrativo.Cliente Find(Domain.Entities.Administrativo.Cliente obj)
        {
            return _wcf.Find(obj);
        }

        public long? Insert(Domain.Entities.Administrativo.Cliente obj)
        {
            return _wcf.Insert(obj);
        }

        public List<Domain.Entities.Administrativo.Cliente> Search(Domain.Entities.Administrativo.Cliente obj)
        {
            return _wcf.Search(obj);
        }

        public bool Update(Domain.Entities.Administrativo.Cliente obj)
        {
            return _wcf.Update(obj);
        }
    }
}
