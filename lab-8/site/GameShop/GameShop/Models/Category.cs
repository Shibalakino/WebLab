using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class Category
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string NameDE { set; get; }
        public string NameUA { set; get; }

        public List<Game> Games { set; get; }
    }
}
