using EshopApplication.Models;
using EshopApplication.Models.spModel;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EshopApplication.DBContextLayer
{
    public class EshopDB:DbContext
    {
        public EshopDB(DbContextOptions<EshopDB>options):base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<LoginUser> loginuser { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<GetProductsFromCart> GetGetProductsFromCarts { get; set; }
        public DbSet<GetOrdersByUserId> getOrdersByUserIds { get; set; }

    }
}
