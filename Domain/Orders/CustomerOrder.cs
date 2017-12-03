using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Location;

namespace Domain.Orders
{
    public class CustomerOrder : Order, ICustomerOrder
    {
        public IAddress BillingAddress { get; set; }
        public IAddress ShippingAddress { get; set; }
    }
}
