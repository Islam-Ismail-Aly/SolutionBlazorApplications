using FirstBlazorApp.Models;

namespace FirstBlazorApp.Interfaces
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> GetByName(string name);
    }
}
