using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Items;

namespace ERP.SCM.Inventory
{
    // Just-in-time inventory management strategy:
    public class JIT : IManagementStrategy
    {
        public IInventory Inventory { get; set; }
    }
}