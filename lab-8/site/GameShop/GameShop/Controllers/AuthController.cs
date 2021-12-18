using GameShop.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Controllers
{
    public class AuthController : Controller
    {
        private readonly GameShopUserContext _gameShopUserContext;
        public AuthController(GameShopUserContext context)
        {
            _gameShopUserContext = context;
        }
        public IActionResult Login()
        {
            return View("~/Areas/Identity/Pages/Account/Login.cshtml");
        }
        public IActionResult Register()
        {
            return View("~/Areas/Identity/Pages/Account/Register.cshtml");
        }
    }
}
