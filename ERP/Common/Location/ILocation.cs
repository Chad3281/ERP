using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Common.Location
{
    public interface ILocation : ICode
    {
        IAddress Address { get; set; }
    }
}
