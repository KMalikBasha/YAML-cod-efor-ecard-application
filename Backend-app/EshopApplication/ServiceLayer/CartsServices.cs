using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using EshopApplication.Models;
using EshopApplication.Models.spModel;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;

namespace EshopApplication.ServiceLayer
{
    public class CartsServices:ICarts
    {
        private readonly EshopDB _db;
        public CartsServices(EshopDB db)
        {
            _db = db;
        }

        public Carts addProductsToCart(Carts items)
        {
            _db.Carts.Add(items);
            _db.SaveChanges();
            return (items);
        }
        public void DeleteProduct(Carts id)
        {
            _db.Carts.Remove(id);
            _db.SaveChanges();
        }

        public Carts GetProduct(int id)
        {
            var product = _db.Carts.Find(id);
            return product;
        }


        //Stored Procedure for display list of products from user Cart
        public List<GetProductsFromCart> GetAllProducts(int userId)
        {
            return _db.GetGetProductsFromCarts.FromSqlRaw($"spGetItemsByUserId {userId}").ToList();
        }

        public void BulkDeleteItemsbyUserId(int userId)
        {
            _db.Database.ExecuteSqlRaw($"spDeleteitemsbyUserId {userId}");
            _db.SaveChanges();
        }
    }
}
