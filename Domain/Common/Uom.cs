using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    class Uom : ICode, IUom
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Quantity { get; set; }
    }
}
