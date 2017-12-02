using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Items
{
    public interface IInventory
    {
        IList<IUnit> Items { get; set; }

        void AddItem();
        void AddItem(IUnit item);

        void RemoveItem();
        void RemoveItem(IUnit item);

        void UpdateItem();
        void UpdateItem(IUnit item);

        IUnit GetItem();
    }
}
