using System.Collections.Generic;
using System.Linq;
using ComputerStore.Models;

namespace ComputerStore
{
    public static class SampleData
    {
        public static void Initialize(ComputerContext context)
        {
            if (!context.Computers.Any())
            {
                context.Computers.AddRange(
                new Computer
                {
                    Title = "Desktop",
                    Description = "AMD Ryzen 3 - 8GB Memory - 256GB SSD - Jet Black",
                    Manufacturer = "HP",
                    Price = 479.99d
                },
                new Computer
                {
                    Title = "IdeaCentre 3 Desktop",
                    Description = "AMD Athlon Silver-Series - 8GB Memory - 256GB SSD - Mineral Grey",
                    Manufacturer = "Lenovo",
                    Price = 399.99d
                },
                new Computer
                {
                    Title = "Pavilion Desktop",
                    Description = "Intel Core i3 - 8GB Memory - 256GB SSD - Natural Silver",
                    Manufacturer = "HP",
                    Price = 519.99d
                },
                new Computer
                {
                    Title = "Inspiron 3880 Desktop",
                    Description = "Intel Core i5 - 12GB Memory - 256B SSD - Black",
                    Manufacturer = "Dell",
                    Price = 679.99d
                },
                new Computer
                {
                    Title = "Inspiron 3880 Desktop",
                    Description = "Intel Core i7 - 12GB Memory - 512GB SSD - Black",
                    Manufacturer = "DELL",
                    Price = 929.99d
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
                    Computers = new List<Computer> {
                        context.Computers.FirstOrDefault(d => d.Title == "Inspiron 3880 Desktop"),
                    },
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
    }
}