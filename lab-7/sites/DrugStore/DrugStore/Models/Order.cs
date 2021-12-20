using System.Collections.Generic;

namespace DrugStore.Models
{
    public class Order
    {
        public Order() { }
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }

        public List<Drug> Drugs { get; set; }
        //public List<OrderDrug> OrderDrugs { get; set; }

    }
}
