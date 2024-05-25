using FirstBlazorApp.Interfaces;
using FirstBlazorApp.Models;
using System.Collections.Immutable;

namespace FirstBlazorApp.Services
{
    public class ProductService : IService<Product>
    {
       private List<Product> _products = new List<Product>
       {
            new Product
            {
                Id = 1,
                Title = "Laptop",
                Price = 999.99M,
                ImageUrl = "laptop.jpg",
                CategoryId = 1,
                Quantity = 5,
                Rating = 3
            },
            new Product
            {
                Id = 2,
                Title = "Smartphone",
                Price = 499.99M,
                ImageUrl = "smartphone.jpg",
                CategoryId = 1,
                Quantity = 0,
                Rating = 3
            },
            new Product
            {
                Id = 3,
                Title = "Headphones",
                Price = 129.99M,
                ImageUrl = "headphones.jpg",
                CategoryId = 1,
                Quantity = 1,
                Rating = 4.5
            },
            new Product
            {
                Id = 4,
                Title = "Backpack",
                Price = 49.99M,
                ImageUrl = "backpack.jpg",
                CategoryId = 2,
                Quantity = 8,
                Rating = 4.2
            },
            new Product
            {
                Id = 5,
                Title = "Watch",
                Price = 299.99M,
                ImageUrl = "watch.jpg",
                CategoryId = 2,
                Quantity = 3,
                Rating = 2
            },
            new Product
            {
                Id = 6,
                Title = "Speaker",
                Price = 199.99M,
                ImageUrl = "speaker.jpg",
                CategoryId = 1,
                Quantity = 7,
                Rating = 4.6
            },
            new Product
            {
                Id = 7,
                Title = "Sunglasses",
                Price = 79.99M,
                ImageUrl = "sunglasses.jpg",
                CategoryId = 2,
                Quantity = 15,
                Rating = 3
            }
        };

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetByName(string name)
        {
            return _products.Where(p => p.Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
