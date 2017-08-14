using pNc.Application.Interface.Administrativo;
using pNc.Application.wcf.Administrativo.ClienteTipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pNc.Application.Administrativo
{
    public class ClienteTipoAppService: IClienteTipoAppService
    {
        private readonly ClienteTipoClient _wcf;

        public ClienteTipoAppService()
        {
            _wcf = new ClienteTipoClient();
        }

        public bool Delete(Domain.Entities.Administrativo.ClienteTipo obj)
        {
            return _wcf.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Administrativo.ClienteTipo Find(Domain.Entities.Administrativo.ClienteTipo obj)
        {
            return _wcf.Find(obj);
        }

        public long? Insert(Domain.Entities.Administrativo.ClienteTipo obj)
        {
            return _wcf.Insert(obj);
        }

        public List<Domain.Entities.Administrativo.ClienteTipo> Search(Domain.Entities.Administrativo.ClienteTipo obj)
        {
            return _wcf.Search(obj);
        }

        public bool Update(Domain.Entities.Administrativo.ClienteTipo obj)
        {
            return _wcf.Update(obj);
        }
    }
}
