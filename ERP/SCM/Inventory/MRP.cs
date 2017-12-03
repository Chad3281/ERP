using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Domain.Items;

namespace ERP.SCM.Inventory
{
    // Materials Requirement Planning inventory management strategy:
    public class MRP : IManagementStrategy
    {
        public IInventory Inventory { get; set; }
    }
}