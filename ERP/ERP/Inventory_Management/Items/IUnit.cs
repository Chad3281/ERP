using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Items
{
    // Stock Keeping Unit (SKU)/Universal Product Code(UPC)/ European Article Number(EAN):
    public interface IUnit
    {
        string Code { get; set; }
    }
}
