using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Items;

namespace ERP.Inventory_Management
{
    // Just-in-time inventory management strategy:
    public class JIT : IManagementStrategy
    {
        public IInventory Inventory { get; set; }
    }
}