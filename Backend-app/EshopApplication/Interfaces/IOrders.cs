using EshopApplication.Models.spModel;
using Models;

namespace EshopApplication.Interfaces
{
    public interface IOrders
    {
        List<Orders> ListOfOrders();

        Orders AddingProducts(Orders products);

        List<GetOrdersByUserId> getUserOrderProducts(int userId);
    
    }
}
