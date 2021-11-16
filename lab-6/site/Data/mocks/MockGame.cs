using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab.Data.interfaces;
using WebLab.Data.Models;

namespace WebLab.Data.mocks
{
    public class MockGame : IAllGame
    {
        private readonly IGameCategory _categoryGame = new MockCategory();
        public IEnumerable<Game> Games
        {
            get => new List<Game>
                {
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },
                    new Game {Name = "Witcher 3", ShortDesc ="", LongDesc = "", Img = "", Price = 200, IsFavourite = true, Availibe = true, Categories = new List<Category> { _categoryGame.AllCategories.ElementAt(0) , _categoryGame.AllCategories.ElementAt(5) } },

                };
            set
            {
                ;
            }
        }
        public IEnumerable<Game> getFavGames { get; set; }

        public Game getObjectGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
