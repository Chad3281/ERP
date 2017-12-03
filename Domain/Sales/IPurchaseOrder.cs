using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Orders;

namespace Domain.Sales
{
    public interface IPurchaseOrder
    {
        ICollection<IOrder> Orders { get; set; }
    }
}
