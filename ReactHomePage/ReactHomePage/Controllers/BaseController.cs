using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReactHomePage.Dtos.User;
using ReactHomePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReactHomePage.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private UserDetails _UserDetails;

        public UserDetails UserDetails
        {
            get
            {
                return _UserDetails;
            }
        }

        public BaseController(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var email = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var role = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
            var isAuthenticated = httpContextAccessor.HttpContext.User.IsAuthenticated();

            var userDetails = new UserDetails()
            {
                UserId = userId,
                Email = email,
                IsAuthenticated = isAuthenticated,
                Role = role
            };
            _UserDetails = userDetails;

        }

    }
}
