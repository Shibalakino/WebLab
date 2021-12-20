using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.Models;
using Microsoft.AspNetCore.Identity;

namespace GameShop.Areas.Identity.Data
{
    public class GameShopUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        public string NickName { get; set; }

        public List<Game> Games { get; set; } 
    }
}
