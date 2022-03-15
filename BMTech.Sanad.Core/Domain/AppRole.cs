using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMTech.Sanad.Core.Domain
{
    public class AppRole : IdentityRole<int>
    {
        public IEnumerable<AppUserRole> RoleUsers { get; set; }
    }
}
