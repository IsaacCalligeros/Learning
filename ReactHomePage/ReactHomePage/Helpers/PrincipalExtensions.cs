using ReactHomePage.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReactHomePage.Helpers
{
    public static class PrincipalExtensions
    {
        private static UserDetails _UserDetails;

        public static UserDetails GetUserDetails(this ClaimsPrincipal claimsPrincipal)
        {
            if(_UserDetails?.UserId != null && _UserDetails?.UserId != 0)
            {
                return _UserDetails;
            }

            var userIdStr = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int.TryParse(userIdStr, out var userId);
            var email = claimsPrincipal.FindFirst(ClaimTypes.Email)?.Value;
            var role = claimsPrincipal.FindFirst(ClaimTypes.Role)?.Value;

            var userDetails = new UserDetails()
            {
                UserId = userId,
                Email = email,
                Role = role
            };

            _UserDetails = userDetails;

            return userDetails;
        }
    }
}
