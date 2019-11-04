using System;
using System.Collections.Generic;
using System.Text;

namespace DmiConsulting.Eshop.Core.Entities
{
    public class OrderItem : BaseEntity
    {
        
        public int Id { get; set; }

        public decimal Price { get; set; }

        public Product OrderedProduct { get; set; }

        public int Quantity { get; set; }


        public decimal TotalPrice => Price * Quantity;

        public OrderAggregation.OrderItemAggregation Order { get; set; }

    }
}
