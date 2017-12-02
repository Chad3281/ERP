using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Location;

namespace Domain.Warehouse
{
    public interface IWarehouse
    {
        ILocation Location { get; set; }
        ICollection<IDockDoor> DockDoors { get; set; }
    }
}
