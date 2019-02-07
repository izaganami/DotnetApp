using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopApp.Models
{
    public class ShopStore : DbContext
    {
        public DbSet<Type> Types { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<ShopApp.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}