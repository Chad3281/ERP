using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Common;
using ERP.Common.Location;

namespace InventoryManagement.Items
{
    public interface IUnit
    {
        ICode Code { get; set; }

        // Unit information:
        double Weight { get; set; }
        double Height { get; set; }
        double Width { get; set; }

        ILocation Location { get; set; }
    }
}
