using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GameShop.Areas.Identity.Data; //

namespace GameShop.Models
{
    public class Game
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string DescriptionDE { set; get; }
        public string DescriptionUA { set; get; }
        public string ImageLink { set; get; }
        public double Price { set; get; }
        public List<Category> Categories { set; get; }
        //public List<User> Users { get; set; }
        public List<GameShopUser> GameShopUsers { get; set; }

    }
}
