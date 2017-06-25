using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Items;

namespace InventoryManagement.OrderManagement
{
    public interface IPurchaseOrder
    {
        IList<IOrder> Orders { get; set; }
    }
}
