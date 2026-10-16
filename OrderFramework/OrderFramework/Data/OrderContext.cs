using Microsoft.EntityFrameworkCore;
using OrderFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFramework.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrderFramework;Integrated Security=True;");
        }
    }
}
