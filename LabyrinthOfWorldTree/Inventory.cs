using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Inventory : Item
    {
        public Dictionary<int, int> IdxAndCount { get; private set; }

        public Inventory()
        {
            IdxAndCount = new Dictionary<int, int>();

            for (int i = 0; i < Items.Count; i++)
            {
                IdxAndCount.Add(i, 0);
            }

            PlusItemCount(23);
            PlusItemCount(16);
            PlusItemCount(8);
            PlusItemCount(19);
            PlusItemCount(3);
            PlusItemCount(7);
        }

        public void PlusItemCount(int itemIdx_)
        {
            IdxAndCount[itemIdx_]++;
        }

        public void MinusItemCount(int itemIdx_)
        {
            IdxAndCount[itemIdx_]--;
        }
    }
}
