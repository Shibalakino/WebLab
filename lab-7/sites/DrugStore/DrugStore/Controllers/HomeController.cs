using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrugStore.Models;
using System.Collections.Generic;

namespace DrugStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly DrugContext _context;
        public HomeController(DrugContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Drugs.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? drugID)
        {
            if (drugID == null) return RedirectToAction("Index");
            ViewBag.Drugs = _context.Drugs.FirstOrDefault(d => d.ID == drugID);
            return View();
        }
        [HttpPost]
        public string Buy(string clientName, string address, string contactPhone, Drug drug)
        {
            Order order = new Order
            {
                ClientName = clientName,
                Address = address,
                ContactPhone = contactPhone,
                Drugs = new List<Drug> { _context.Drugs.First(d => d.Title == drug.Title) }
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return "Thanks for the purchase, "+ order.ClientName;
        }
        public IActionResult Ordered()
        {
            var ordersDataAnonymous = (from o in _context.Orders
                              select new
                              {
                                  ClientName = o.ClientName,
                                  Address = o.Address,
                                  ContactPhone = o.ContactPhone,
                                  DrugTitle = o.Drugs.First().Title
                              });

            List < (string ClientName, string Address, string ContactPhone, string DrugTitle) > ordersData
                = new List<(string, string, string, string)>();
            foreach (var od in ordersDataAnonymous)
            {
                ordersData.Add(( od.ClientName, od.Address, od.ContactPhone, od.DrugTitle ));
            }
            ViewData["OrdersData"] = ordersData;
            return View();
        }
    }
}