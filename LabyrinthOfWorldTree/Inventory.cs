using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Inventory : Item
    {
        public Dictionary<string, int> NameAndCount { get; private set; }

        public Inventory()
        {
            NameAndCount = new Dictionary<string, int>();

            for (int i = 0; i < Items.Count; i++)
            {
                NameAndCount.Add(Items[i].ItemName, 0);
            }
        }

        public void PlusItemCount(string key_)
        {
            NameAndCount[key_]++;
        }
    }
}
