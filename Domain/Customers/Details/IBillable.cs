using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Location;

namespace Domain.Customers.Details
{
    public interface IBillable
    {
        IAddress BillingAddress { get; set; }
    }
}
