using System;
using System.Collections.Generic;
using System.Text;

namespace DmiConsulting.Eshop.Core.Entities
{
    public class ProductCategory
    { 

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public ProductCategory()
        {
            Products = new List<Product>();
        }
    }
}
