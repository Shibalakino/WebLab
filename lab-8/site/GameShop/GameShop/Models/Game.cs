using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class Game
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string ImageLink { set; get; }
        public double Price { set; get; }
        //public bool IsFavourite { set; get; }
        //public bool Availibe { set; get; }
        //public int CategoryID { set; get; }
        public List<Category> Categories { set; get; }
        public List<User> Users { get; set; }
    }
}
