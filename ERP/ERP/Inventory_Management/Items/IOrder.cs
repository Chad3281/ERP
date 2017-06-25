﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Items
{
    public interface IOrder
    {
        int Quantity { get; set; }
        double Price { get; set; }
        double Total { get; set; }
    }
}