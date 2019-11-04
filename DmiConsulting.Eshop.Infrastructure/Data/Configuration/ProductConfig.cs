using System;
using System.Collections.Generic;
using System.Text;
using DmiConsulting.Eshop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DmiConsulting.Eshop.Infrastructure.Data.Configuration
{
    class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Price).IsRequired();
            //builder.Property(p => p.Category).IsRequired();
            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey("CategoryName");
            builder.HasMany(p => p.OrderItems).WithOne(o => o.OrderedProduct);


        }
    }
}
