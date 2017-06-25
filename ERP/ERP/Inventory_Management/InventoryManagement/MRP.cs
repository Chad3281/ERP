using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.InventoryManagement
{
    // Materials Requirement Planning inventory management strategy:
    public class MRP : IManagementStrategy
    {
        public IInventory Inventory { get; set; }
    }
}