using GameShop.Areas.Identity.Data;
using GameShop.Data;
using GameShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameContext _gameContext;
        public HomeController(GameContext context)
        {
            _gameContext = context;
        }
        [Route("")]
        [Route("~/Home")]
        [Route("~/Home/Index")]
        [Route("~/Home/Index/{userName?}")]
        [Route("~/Home/Index/{userName?}/{categoryName?}")]
        public IActionResult Index(string userName, string categoryName)
        {
            var gamesAnonymous = (categoryName == null || categoryName == "AllGames")
                ?
                 (from g in _gameContext.Games
                  select new
                  {
                      Title = g.Title,
                      Categories = g.Categories,
                      Description = g.Description,
                      Price = g.Price,
                      ImageLink = g.ImageLink
                  }).ToList()
                :
                 (from g in _gameContext.Games
                  where g.Categories.Any(c => c.Name == categoryName)
                  select new
                  {
                      Title = g.Title,
                      Categories = g.Categories,
                      Description = g.Description,
                      Price = g.Price,
                      ImageLink = g.ImageLink
                  }).ToList();
            if (userName != null && userName != "Shop")
            {
                gamesAnonymous = (categoryName == null || categoryName == "AllGames")
                ?
                 (from g in _gameContext.Games
                  where g.GameShopUsers.Any(u => u.UserName == userName)
                  select new
                  {
                      Title = g.Title,
                      Categories = g.Categories,
                      Description = g.Description,
                      Price = g.Price,
                      ImageLink = g.ImageLink
                  }).ToList()
                :
                 (from g in _gameContext.Games
                  where g.Categories.Any(c => c.Name == categoryName)
                        && g.GameShopUsers.Any(u => u.UserName == userName)
                  select new
                  {
                      Title = g.Title,
                      Categories = g.Categories,
                      Description = g.Description,
                      Price = g.Price,
                      ImageLink = g.ImageLink
                  }).ToList();
            }
            List<(string Title, List<Category> Categories, string Description, double Price, string ImageLink)> games
                = new List<(string, List<Category>, string, double, string)>();
            foreach (var g in gamesAnonymous)
            {
                games.Add((g.Title, g.Categories, g.Description, g.Price, g.ImageLink));
            }
            ViewData["Games"] = games;
            ViewData["Categories"] = _gameContext.Categories.ToList();
            //ViewData["Games"] = _gameContext.Games.Where(g => g.Categories.Any(c => c.Name == categoryName)).ToList();
            return View();
        }
        //[Route("~/Home/Index/{userName?}/{categoryName?}")]
        public IActionResult Buy(string userName, string gameTitle)
        {
            if (
                !(from u in _gameContext.GameShopUsers
                where u.UserName == userName
                && u.Games.Any(g => g.Title == gameTitle)
                select u).Any())
            {
                if (_gameContext.GameShopUsers.ToList().Find(u => u.UserName == userName).Games == null)
                {
                    _gameContext.GameShopUsers.ToList().Find(u => u.UserName == userName).Games
                        = new List<Game> { _gameContext.Games.First(g => g.Title == gameTitle) };
                }
                else
                {
                    _gameContext.GameShopUsers.ToList().Find(u => u.UserName == userName).Games
                        .Add(_gameContext.Games.First(g => g.Title == gameTitle));
                }
                _gameContext.SaveChanges();
                ViewData["PurchaseResult"] = "Purchase successful!";
            }
            else
            {
                ViewData["PurchaseResult"] = "You already own " + gameTitle + "!";
            }
            return View("PurchaseResult");
        }
    }
}
