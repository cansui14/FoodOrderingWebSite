﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istka_Group4_FoodOrdering_Entity.Entities
{
    public class Feedback : BaseEntity
    {
        public string Description { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
       
        public virtual Product Product { get; set; }


    }
}
