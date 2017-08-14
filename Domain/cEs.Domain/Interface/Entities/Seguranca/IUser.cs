using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace cEs.Domain.Interface.Entities.Seguranca
{
    public interface IUser
    {
        string Name { get; }

        //string Id { get; }
        //string Id { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
