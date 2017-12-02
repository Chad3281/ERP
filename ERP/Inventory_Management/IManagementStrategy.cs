using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Items;

namespace ERP.Inventory_Management
{

    // Inventory management strategies such as JIT/MRP/etc.
    public interface IManagementStrategy
    {
        IInventory Inventory { get; set; }
    }
}
