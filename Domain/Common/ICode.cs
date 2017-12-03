using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    // Stock Keeping Unit (SKU)/Universal Product Code(UPC)/ European Article Number(EAN):
    // TODO: Consider branching ICode out to an IIdentifiable and IDescribable and changing Code to Id. 
    public interface ICode
    {
       string Code { get; set; }
       string Name { get; set; }
       string Description { get; set; }
    }
}
