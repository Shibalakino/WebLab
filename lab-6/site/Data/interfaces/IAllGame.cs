using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab.Data.Models;

namespace WebLab.Data.interfaces
{
    public interface IAllGame
    {
        IEnumerable<Game> Games { get;}
        IEnumerable<Game> getFavGames { get;}
        Game getObjectGame(int gameId);
    }
}
