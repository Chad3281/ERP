using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders
{
    public interface IOrder
    {
        string Id { get; set; }

        // TODO: Move to order-line level:
        /*double Quantity { get; set; } D
        double Price { get; set; }
        double Total { get; set; }*/
    }
}
