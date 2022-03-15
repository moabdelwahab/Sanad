﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMTech.Sanad.Core.Domain
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public AppUser AppUser { get; set; }
        public AppRole AppRole { get; set; }
    }
}
