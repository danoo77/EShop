using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DmiConsulting.Eshop.Core.Entities.OrderAggregation
{
    public class OrderItemAggregation : BaseEntity
    {
        public int Id { get; set; }

        public ICollection<OrderItem> OrderedItems { get; private set; }

        public decimal TotalPrice => OrderedItems.Sum(_ => _.TotalPrice);

        public DateTime OrderTime { get; set; }

        public int TotalProductsCount => OrderedItems.Select(_ => _.OrderedProduct).Distinct(new BaseItemEqualityComparer()).Count();

        public OrderItemAggregation()
        {
            OrderedItems = new List<OrderItem>();
        }
    }
}
