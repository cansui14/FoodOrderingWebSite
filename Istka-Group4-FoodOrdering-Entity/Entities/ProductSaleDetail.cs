﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istka_Group4_FoodOrdering_Entity.Entities
{
    public class ProductSaleDetail : BaseEntity
    {
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductId { get; set; }
        public int ProductSaleId { get; set; }

        public ProductSale ProductSale { get; set; }   

        public virtual Product Product { get; set; }   
    }
}
