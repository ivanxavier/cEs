using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace cEs.Infra.Authentication.Class
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// User ID
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string getUserId(this ClaimsPrincipal user)
        {
            if (user != null)
            {
                if (!user.Identity.IsAuthenticated)
                    return null;

                ClaimsPrincipal currentUser = user;
                return currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
            else
            {
                return null;
            }
        }

    }
}
