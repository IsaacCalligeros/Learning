using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace ReactHomePage.Helpers
{
    public static class UserHelper
    {
        public static long GetUserId(this IPrincipal user)
        {
            if (long.TryParse(user.Identity.Name, out var userId))
            {
                return userId;
            }

            return 0L;
        }
    }
}
