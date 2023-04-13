using EshopApplication.Models;
using EshopApplication.Models.spModel;
using Models;

namespace EshopApplication.Interfaces
{
    public interface ICarts
    {
        Carts addProductsToCart(Carts items);
        void DeleteProduct(Carts id);
        Carts GetProduct(int id);

        List<GetProductsFromCart> GetAllProducts(int userId);

        void BulkDeleteItemsbyUserId(int userId);
    }
}
