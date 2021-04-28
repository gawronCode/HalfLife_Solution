using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HalfLife.Models.DbModels
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string SecondName { get; set; }

    }
}
