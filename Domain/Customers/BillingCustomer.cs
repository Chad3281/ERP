using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Location;
using Domain.Customers.Details;

namespace Domain.Customers
{
    public class BillingCustomer : Customer, IBillingCustomer
    {
        public IAddress BillingAddress { get; set; }
    }
}
