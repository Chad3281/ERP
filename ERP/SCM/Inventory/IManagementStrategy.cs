using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Items;

namespace ERP.SCM.Inventory
{
    // Inventory management strategies such as JIT/MRP/etc.
    public interface IManagementStrategy
    {
        IInventory Inventory { get; set; }
    }
}
