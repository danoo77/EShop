using System;
using System.Collections.Generic;
using System.Text;
using DmiConsulting.Eshop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DmiConsulting.Eshop.Infrastructure.Data.Configuration
{
    class CategoryConfig : IEntityTypeConfiguration<ProductCategory>

    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(c => c.Name);
            builder.Property(p => p.Name).IsRequired();
            builder.HasMany(p => p.Products).WithOne(c => c.Category);

            builder.HasData(new ProductCategory() {Name = "Dogs"}, new ProductCategory() {Name = "Cats"},
                new ProductCategory() {Name = "Others"});
        }
    }
}
