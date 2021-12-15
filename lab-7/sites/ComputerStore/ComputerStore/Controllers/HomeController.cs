using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ComputerStore.Models;
using System.Collections.Generic;

namespace ComputerStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ComputerContext _context;
        public HomeController(ComputerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Computers.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? computerID)
        {
            if (computerID == null) return RedirectToAction("Index");
            ViewBag.Computers = _context.Computers.FirstOrDefault(d => d.ID == computerID);
            return View();
        }
        [HttpPost]
        public string Buy(string clientName, string address, string contactPhone, Computer computer)
        {
            Order order = new Order
            {
                ClientName = clientName,
                Address = address,
                ContactPhone = contactPhone,
                Computers = new List<Computer> { _context.Computers.First(d => d.Title == computer.Title) }
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return "Thanks for the purchase, " + order.ClientName;
        }
        public IActionResult Ordered()
        {
            var ordersDataAnonymous = (from o in _context.Orders
                                       select new
                                       {
                                           ClientName = o.ClientName,
                                           Address = o.Address,
                                           ContactPhone = o.ContactPhone,
                                           ComputerTitle = o.Computers.First().Title
                                       });

            List<(string ClientName, string Address, string ContactPhone, string ComputerTitle)> ordersData
                = new List<(string, string, string, string)>();
            foreach (var od in ordersDataAnonymous)
            {
                ordersData.Add((od.ClientName, od.Address, od.ContactPhone, od.ComputerTitle));
            }
            ViewData["OrdersData"] = ordersData;
            return View();
        }
    }
}