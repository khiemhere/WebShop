﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webShopSolution.Data.Entities
{
    public class ProductInCategory
    {
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
