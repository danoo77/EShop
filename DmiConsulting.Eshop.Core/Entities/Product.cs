using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DmiConsulting.Eshop.Core.Entities
{
    public class Product : BaseEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ProductCategory Category { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public Product()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
