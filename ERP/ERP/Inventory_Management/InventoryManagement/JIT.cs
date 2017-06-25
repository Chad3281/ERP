using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.InventoryManagement
{
    // Just-in-time inventory management strategy:
    public class JIT : IManagementStrategy
    {
        public IInventory Inventory { get; set; }
    }
}