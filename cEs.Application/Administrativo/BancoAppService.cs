using pNc.Application.Interface.Administrativo;
using pNc.Application.wcf.Administrativo.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pNc.Application.Administrativo
{
    public class BancoAppService: IBancoAppService
    {
        private readonly BancoClient _wcf;

        public BancoAppService()
        {
            _wcf = new BancoClient();
        }

        public bool Delete(Domain.Entities.Administrativo.Banco obj)
        {
            return _wcf.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Administrativo.Banco Find(Domain.Entities.Administrativo.Banco obj)
        {
            return _wcf.Find(obj);
        }

        public long? Insert(Domain.Entities.Administrativo.Banco obj)
        {
            return _wcf.Insert(obj);
        }

        public List<Domain.Entities.Administrativo.Banco> Search(Domain.Entities.Administrativo.Banco obj)
        {
            return _wcf.Search(obj);
        }

        public bool Update(Domain.Entities.Administrativo.Banco obj)
        {
            return _wcf.Update(obj);
        }
    }
}
