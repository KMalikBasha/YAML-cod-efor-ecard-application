using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EshopApplication.ServiceLayer
{
    public class ProductServices:IProducts
    {
        private readonly EshopDB _Db;
        public ProductServices(EshopDB db)
        {
            _Db = db;
        }

        public Products AddProducts(Products products)
        {
            _Db.Products.Add(products);
            _Db.SaveChanges();
            return products;
        }

        public Products GetProductById(int id)
        {
            return _Db.Products.Find(id);
        }

        public List<Products> GetProducts()
        {

            /*return _Db.Products.ToList();*/
            return _Db.Products.FromSqlRaw($"spGetAllProducts").ToList();
        }

        public List<Products> GetProductsByCategory(int categoryId)
        {
            /* List<Products> products = _Db.Products.ToList();
             List<Products> specificCategorylist = new List<Products>();
             foreach(Products item in products)
             {
                 if(item.CategoryId == categoryId)
                 {
                     specificCategorylist.Add(item);
                 }
             }
             return specificCategorylist;*/
            return _Db.Products.FromSqlRaw($"spGetProductsByCategoryId {categoryId}").ToList();
        }
    }
}
