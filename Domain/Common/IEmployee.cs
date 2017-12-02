using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IEmployee
    {
        int ID { get; set; }

        string Name { get; set; }
        string Title { get; set; }

        ISchedule Schedule { get; set; }
    }
}
