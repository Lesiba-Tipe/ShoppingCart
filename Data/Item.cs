
using System.Collections.Generic;

namespace ShoppingCart.Data
{

    public class Item
    {
        public int Id { get; set; }
        public int ItemCollectionId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

    }

    public class ItemService
    {
        public List<Item> Items = new List<Item>()
{
            new Item(){ Id = 0, Name = "Laptop", Price = 7500, Description = "visit website..."},
            new Item(){ Id = 1, Name = "Hard disk", Price = 1100, Description = "visit website..."},
            new Item(){ Id = 2, Name = "office chair", Price = 600, Description = "visit website..."},
            new Item(){ Id = 3, Name = "tablet", Price = 2100, Description = "visit website..."},
            new Item(){ Id = 4, Name = "power bank", Price = 200, Description = "visit website..."},
            new Item(){ Id = 5, Name = "back pack", Price = 500, Description = "visit website..."}
        };

    }
}
