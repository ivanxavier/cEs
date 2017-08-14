using cEs.Domain.Interface.Entities.Seguranca;

namespace cEs.Domain.Entities.Seguranca
{
    public class PaginaPerfil: IPaginaPerfil
    {
        #region Implementation of IPaginaPerfil

        public long? MenuId{get ; set ;}

        public string MenuNome{get ; set ; }

        public long? PaginaId{get ; set ;}

        public string PaginaNome{get ; set ;}

        public long? PaginaPerfilId{get ; set ; }

        public long? PerfilId{ get ; set ;}

        public string PerfilNome{get ; set ; }

        public long? AcessoId{ get ; set ;}

        #endregion
    }
}
