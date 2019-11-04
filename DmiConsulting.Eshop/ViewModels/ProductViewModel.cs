﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reinforced.Typings.Attributes;

namespace DmiConsulting.Eshop.ViewModels
{
    [TsInterface(Name = "Product", IncludeNamespace = false, AutoI = false)]
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
