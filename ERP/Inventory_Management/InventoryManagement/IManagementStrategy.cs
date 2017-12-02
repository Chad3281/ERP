using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.InventoryManagement
{

    // Inventory management strategies such as JIT/MRP/etc.
    public interface IManagementStrategy
    {
        IInventory Inventory { get; set; }
    }
}
