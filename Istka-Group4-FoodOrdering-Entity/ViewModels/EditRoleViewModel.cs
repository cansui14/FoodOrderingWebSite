﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istka_Group4_FoodOrdering_Entity.ViewModels
{
    public class EditRoleViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] UserIdsToAdd { get; set; }
        public string[] UserIdsToDelete { get; set; }
    }
}
