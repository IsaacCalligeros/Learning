﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
    }
    public class AppRole : IdentityRole<int>
    {
    }
}
