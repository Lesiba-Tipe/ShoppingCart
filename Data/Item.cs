using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public class Item
    {
        public int id { get; set; }
        public int itemCollectionId { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }


    }
}
