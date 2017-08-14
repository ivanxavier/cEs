using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Infra.Authentication.DataModel
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
