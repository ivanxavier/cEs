using System;
using System.Collections.Generic;
using cEs.Domain.Interface.Entities;
using System.Runtime.Serialization;
using cEs.Domain.Interface.Entities.Seguranca;
using cEs.Domain.Entities.Administrativo;

namespace cEs.Domain.Entities.Seguranca
{
    [DataContract]
    public class Acesso : IAcesso
    {
        [DataMember]
        public long? AcessoId { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Senha { get; set; }
        [DataMember]
        public PerfilTipo PerfilTipo { get; set; }
        [DataMember]
        public bool Ativo { get; set; }
        [DataMember]
        public long? PerfilTipoId { get; set; }
        [DataMember]
        public long? UsuarioId { get; set; }
        [DataMember]
        public long? EmpresaId { get; set; }
        [DataMember]
        public string Empresa { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string CelularDDD { get; set; }
        [DataMember]
        public string CelularNumero { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string AspNetUser { get; set; }
    }

}
