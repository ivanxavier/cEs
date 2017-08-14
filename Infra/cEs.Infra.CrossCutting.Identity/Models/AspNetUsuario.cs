using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace cEs.Infra.CrossCutting.Identity.Models
{
    public class AspNetUsuario : IAcessoUsuario
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUsuario(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Nome => _accessor.HttpContext.User.Identity.Name;

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }

        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;

        }

    }
}
