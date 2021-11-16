using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab.Data.Models
{
    public class Game
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string ShortDesc { set; get; }
        public string LongDesc { set; get; }
        public string Img { set; get; } //idk what type of img
        public decimal Price { set; get; }
        public bool IsFavourite { set; get; }
        public bool Availibe { set; get; }
        public int CategoryID { set; get; }
        public virtual List<Category> Categories { set; get; }
    }
}
