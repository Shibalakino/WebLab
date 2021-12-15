using System.Collections.Generic;

namespace ComputerStore.Models
{
    public class Order
    {
        public Order() { }
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }

        public List<Computer> Computers { get; set; }
        //public List<OrderComputer> OrderComputers { get; set; }

    }
}
