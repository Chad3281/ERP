﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Common {
   public interface ICode {
       string Code { get; set; }
       string Name { get; set; }
       string Description { get; set; }
    }
}
