using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class User
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }

        public List<Game> Games { get; set; }
    }
}
