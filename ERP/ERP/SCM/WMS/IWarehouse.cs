using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Common.Location;

namespace ERP.SCM.WMS
{
    public interface IWarehouse
    {
        ILocation Location { get; set; }
        ICollection<IDockDoor> DockDoors { get; set; }
    }
}
