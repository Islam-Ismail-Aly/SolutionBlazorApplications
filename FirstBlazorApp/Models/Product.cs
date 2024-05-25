namespace FirstBlazorApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; } // Reference to Category ID
        public Category Category { get; set; }
        public int Quantity { get; set; }
        public double Rating { get; set; }
    }
}
