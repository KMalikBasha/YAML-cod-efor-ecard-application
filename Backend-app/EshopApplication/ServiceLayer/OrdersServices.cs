using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using EshopApplication.Models.spModel;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EshopApplication.ServiceLayer
{
    public class OrdersServices: IOrders
    {
        private readonly EshopDB eshopDB;
        public OrdersServices(EshopDB eshopDB)
        {
            this.eshopDB = eshopDB;
        }

        public List<Orders> ListOfOrders()
        {
            return eshopDB.Orders.ToList();
        }
        public Orders AddingProducts(Orders orders)
        {
            orders.OrderDate = DateTime.Now;
            eshopDB.Orders.Add(orders);
            eshopDB.SaveChanges();
            return (orders);
        }

        public List<GetOrdersByUserId> getUserOrderProducts(int userId)
        {
            return eshopDB.getOrdersByUserIds.FromSqlRaw($"spGetOrdersByUserId {userId}").ToList();
        }
    }
}
