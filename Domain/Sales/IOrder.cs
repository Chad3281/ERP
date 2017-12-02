﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Sales
{
    public interface IOrder
    {
        double Quantity { get; set; }
        double Price { get; set; }
        double Total { get; set; }
    }
}