using System.Collections.Generic;

namespace DrugStore.Models
{
    public class Drug
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public List<Order> Orders { get; set; }
        //public List<OrderDrug> OrderDrugs { get; set; }

    }
}
