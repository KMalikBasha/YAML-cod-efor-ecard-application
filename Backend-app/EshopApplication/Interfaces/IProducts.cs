using Models;

namespace EshopApplication.Interfaces
{
    public interface IProducts
    {
        List<Products> GetProducts();

        Products AddProducts(Products products);

        List<Products> GetProductsByCategory(int categoryId);

        Products GetProductById(int id);
    }
}
