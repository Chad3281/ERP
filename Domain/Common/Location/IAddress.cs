using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Location
{
    public interface IAddress
    {
        ICity City { get; set; }
        IState State { get; set; }
        IPostalCode PostalCode { get; set; }
    }
}
