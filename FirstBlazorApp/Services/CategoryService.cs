using FirstBlazorApp.Interfaces;
using FirstBlazorApp.Models;

namespace FirstBlazorApp.Services
{
    public class CategoryService : IService<Category>
    {
        private List<Category> _categories = new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Fashion" },
        };

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetByName(string name)
        {
            return _categories.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
