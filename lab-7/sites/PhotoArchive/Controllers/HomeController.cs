using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhotoArchive.Models;
using System.Collections.Generic;

namespace PhotoArchive.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhotoArchiveContext db;
        public HomeController(PhotoArchiveContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Photos.ToList());

        }

        [HttpGet]
        public IActionResult AddPhoto()
        {
            return View();
        }

        [HttpPost]
        public string AddPhoto(string name, string Ref, string desc, int year, int authorId)
        {
            Photo photo = new Photo
            {
                Name = name,
                Ref = Ref,
                Desc = desc,
                Year = year,
                AuthorId = authorId
            };
            db.Photos.Add(photo);
            db.SaveChanges();
            return photo.Name + "is archived!";
        }
    }
}