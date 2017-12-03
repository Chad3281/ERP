using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public class Customer : ICustomer
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
