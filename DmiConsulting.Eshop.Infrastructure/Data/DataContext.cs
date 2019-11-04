using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DmiConsulting.Eshop.Core.Entities;
using DmiConsulting.Eshop.Core.Entities.OrderAggregation;
using Microsoft.EntityFrameworkCore;

namespace DmiConsulting.Eshop.Infrastructure.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DataContext() { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<OrderItemAggregation> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new Configuration.CategoryConfig());
            modelBuilder.ApplyConfiguration(new Configuration.OrderConfig());
            modelBuilder.ApplyConfiguration(new Configuration.OrderItemConfig());
            modelBuilder.ApplyConfiguration(new Configuration.ProductConfig());
        }

       
    }
}
