using System;
using System.Collections.Generic;
using System.Text;
using DmiConsulting.Eshop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DmiConsulting.Eshop.Infrastructure.Data.Configuration
{
    class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).IsRequired();
            //builder.Property(o => o.OrderedProduct).IsRequired();
            builder.Property(o => o.Price).IsRequired();
            builder.Property(o => o.Quantity).IsRequired();
            builder.Ignore(o => o.TotalPrice);
            //builder.Property(o => o.Order).IsRequired();
            builder.HasOne(o => o.OrderedProduct).WithMany(p => p.OrderItems);
            builder.HasOne(o => o.Order).WithMany(o => o.OrderedItems);
        }
    }
}
