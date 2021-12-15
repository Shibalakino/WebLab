using System.Collections.Generic;

namespace ComputerStore.Models
{
    public class Computer
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public List<Order> Orders { get; set; }
        //public List<OrderComputer> OrderComputers { get; set; }

    }
}
