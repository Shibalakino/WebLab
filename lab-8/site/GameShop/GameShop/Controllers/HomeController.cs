using GameShop.Areas.Identity.Data;
using GameShop.Data;
using GameShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
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
        private readonly IHtmlLocalizer<HomeController> _localizer;
        public HomeController(GameContext context, IHtmlLocalizer<HomeController> localizer)
        {
            _gameContext = context;
            _localizer = localizer;
        }
        [Route("")]
        [Route("~/Home")]
        [Route("~/Home/Index")]
        [Route("~/Home/Index/{userName?}")]
        [Route("~/Home/Index/{userName?}/{categoryName?}")]
        public IActionResult Index(string userName, string categoryName, string lang)
        {
            if (lang == null)
                lang = "en";
            else if (lang == "uk-UA")
                lang = "ua";

            List<(string Title, List<Category> Categories, string Description, double Price, string ImageLink)> games = null;
            if (userName == null || userName == "Shop")
            {
                if (categoryName == null || categoryName == "AllGames")
                {
                    games = _gameContext.Games
                         .Select(g => new
                         {
                             g.Title,
                             g.Categories,
                             Description = (lang == "en") ? g.Description : (lang == "de") ? g.DescriptionDE : g.DescriptionUA,
                             g.Price,
                             g.ImageLink
                          })
                        .AsEnumerable()
                        .Select(g => (g.Title, g.Categories, g.Description, g.Price, g.ImageLink))
                        .ToList();
                }
                else
                {
                    games = _gameContext.Games
                         .Select(g => new
                         {
                             g.Title,
                             g.Categories,
                             Description = (lang == "en") ? g.Description : (lang == "de") ? g.DescriptionDE : g.DescriptionUA,
                             g.Price,
                             g.ImageLink
                         })
                        .Where(g => g.Categories.Any(c => c.Name == categoryName))
                        .AsEnumerable()
                        .Select(g => (g.Title, g.Categories, g.Description, g.Price, g.ImageLink))
                        .ToList();
                }
            }
            else
            {
                if (categoryName == null || categoryName == "AllGames")
                {
                    //gamesN = _gameContext.GameShopUsers.Single(u => u.UserName == userName).Games;
                    games = _gameContext.Games
                            .Where(g => g.GameShopUsers.Any(u => u.UserName == userName))
                            .Select(g => new
                            {
                                g.Title,
                                g.Categories,
                                Description = (lang == "en") ? g.Description : (lang == "de") ? g.DescriptionDE : g.DescriptionUA,
                                g.Price,
                                g.ImageLink
                            })
                            .AsEnumerable()
                            .Select(g => (g.Title, g.Categories, g.Description, g.Price, g.ImageLink))
                            .ToList();
                }
                else
                {
                    games = _gameContext.Games
                         .Where(g => g.GameShopUsers.Any(u => u.UserName == userName)
                            && g.Categories.Any(c => c.Name == categoryName))
                         .Select(g => new
                         {
                             g.Title,
                             g.Categories,
                             Description = (lang == "en") ? g.Description : (lang == "de") ? g.DescriptionDE : g.DescriptionUA,
                             g.Price,
                             g.ImageLink
                         })
                        .AsEnumerable()
                        .Select(g => (g.Title, g.Categories, g.Description, g.Price, g.ImageLink))
                        .ToList();
                }
            }
            ViewData["Games"] = games;

            List<string> categoryNames = new List<string>();
            foreach (var cat in _gameContext.Categories)
            {
                if (lang == "en")
                {
                    categoryNames.Add(cat.Name);
                }
                else if (lang == "de")
                {
                    categoryNames.Add(cat.NameDE);
                }
                else
                {
                    categoryNames.Add(cat.NameUA);
                }
            }
            ViewData["CategoryNames"] = categoryNames;
            return View();
        }
        [Route("~/Home/Buy/{userName?}/{gameTitle?}")]
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
                ViewData["PurchaseResult"] = _localizer["Purchase successful!"];
            }
            else
            {
                ViewData["PurchaseResult"] = _localizer["You already own this game!"];
            }
            return View("PurchaseResult");
        }
        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions {Expires = DateTimeOffset.Now.AddDays(30) });
            int index = returnUrl.IndexOf("?");
            if (index > 0)
                returnUrl = returnUrl.Substring(0, index);
            return LocalRedirect(returnUrl);
        }
    }
}
