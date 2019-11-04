using System;
using System.Collections.Generic;
using System.Text;
using DmiConsulting.Eshop.Core.Entities.OrderAggregation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DmiConsulting.Eshop.Infrastructure.Data.Configuration
{
    class OrderConfig : IEntityTypeConfiguration<OrderItemAggregation>
    {
        public void Configure(EntityTypeBuilder<OrderItemAggregation> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).IsRequired();
            builder.Property(o => o.OrderTime).IsRequired();
            builder.Ignore(o => o.TotalPrice);
            builder.Ignore(o => o.TotalProductsCount);
            builder.HasMany(o => o.OrderedItems).WithOne(o => o.Order);
        }
    }
}
