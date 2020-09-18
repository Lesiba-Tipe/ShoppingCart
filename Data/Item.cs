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
}