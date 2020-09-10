using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public class AddItemsToCart
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }

    public class AddItemsToCartService
    {
        public List<AddItemsToCart> ItemsInCart = new List<AddItemsToCart>();
    }

}
