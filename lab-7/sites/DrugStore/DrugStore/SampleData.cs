using System.Collections.Generic;
using System.Linq;
using DrugStore.Models;

namespace DrugStore
{
    public static class SampleData
    {
        public static void Initialize(DrugContext context)
        {
            if (!context.Drugs.Any())
            {
                context.Drugs.AddRange(
                new Drug
                {
                    Title = "Aspirine",
                    Description = "This is aspirine",
                    Manufacturer = "KhersonPharm",
                    Price = 11.11d
                },
                new Drug
                {
                    Title = "Lidocaine",
                    Description = "This is lidocaine",
                    Manufacturer = "KhersonPharm",
                    Price = 22.22d
                },
                new Drug
                {
                    Title = "Ibuprophen",
                    Description = "This is ibuprophen",
                    Manufacturer = "KhersonPharm",
                    Price = 33.33d
                }
                );
            context.SaveChanges();
            }
            if (!context.Orders.Any())
            {
                var order = new Order
                {
                    ClientName = "firstUser",
                    Address = "firstAddress",
                    ContactPhone = "001",
                    Drugs = new List<Drug> {
                        context.Drugs.FirstOrDefault(d => d.Title == "Aspirine"),
                    },
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
    }
}