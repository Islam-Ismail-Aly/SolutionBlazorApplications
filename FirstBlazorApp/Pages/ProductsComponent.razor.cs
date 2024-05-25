using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace FirstBlazorApp.Pages
{
    public partial class ProductsComponent
    {
        private List<Product> products = new();
        private List<Product> filteredProducts = new();


        protected override void OnInitialized()
        {
            products = ProductService.GetAll();
            filteredProducts = products;
        }

        private void OnProductSelected(ChangeEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Value?.ToString()))
            {
                filteredProducts = products;
            }
            else
            {
                filteredProducts = ProductService.GetByName(e.Value.ToString());
            }
        }

        private void NavigateToDetails(int productId)
        {
            Navigation.NavigateTo($"/ProductDetails/{productId}");
        }

        private void NavigateToEdit(int productId)
        {
            Navigation.NavigateTo($"/ProductEdit/{productId}");
        }
    }
}
