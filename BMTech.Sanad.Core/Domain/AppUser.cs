using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMTech.Sanad.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace BMTech.Sanad.Core.Domain
{
    public class AppUser : IdentityUser<int>
    {
        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string NationalNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhotoUrl { get; set; }
        public AccountType AccountType { get; set; }
        public JobType jobType { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public IEnumerable<AppUserRole> UserRoles { get; set; } 

    }
}
