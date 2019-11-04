using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reinforced.Typings.Attributes;

namespace DmiConsulting.Eshop.ViewModels
{

    [TsInterface(Name = "OrderItem", IncludeNamespace = false, AutoI = false)]
    public class OrderItemViewModel
    {

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
