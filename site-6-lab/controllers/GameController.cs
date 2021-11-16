using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab.Data.interfaces;
using WebLab.ViewModels;

namespace WebLab.controllers
{
    public class GameController : Controller
    {
        private readonly IAllGame _allGame;
        private readonly IGameCategory _allCetegory;

        public GameController(IAllGame iAllGame , IGameCategory igameCategory)
        {
            _allGame = iAllGame;
            _allCetegory = igameCategory;
        }
        public ViewResult List()
        {
            GameListViewModel obj = new GameListViewModel();
            obj.getAllGame = _allGame.Games;
            obj.currCategory = "Екшн";
            return View(obj);
        }
    }
}
