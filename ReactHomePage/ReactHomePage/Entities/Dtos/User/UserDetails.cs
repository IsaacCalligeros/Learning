using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Dtos.User
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Role { get; set; }
    }
}
