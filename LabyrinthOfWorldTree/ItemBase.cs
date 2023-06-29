using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class ItemBase
    {
        public int ItemID { get; protected set; }
        public string ItemType { get; protected set; }
        public string ItemName { get; protected set; }
        public int ItemPrice { get; protected set; }
        public int ItemAtk { get; protected set; }
        public int ItemDef { get; protected set; }
        public int[] PlusStat { get; private set; }

        public void SetItemStatus(int id_, string name_, int price_, int atk_, int def_, int str_, int tec_, int vit_, int wis_, int res_)
        {
            ItemID = id_;

            if (ItemID > 100 && ItemID < 201)
            {
                ItemType = "무기　　";
            }
            else if (ItemID > 200 && ItemID < 301)
            {
                ItemType = "방어구　";
            }
            else if (ItemID > 300 && ItemID < 401)
            {
                ItemType = "악세사리";
            }
            else if (ItemID > 400 && ItemID < 501)
            {
                ItemType = "소모품　";
            }
            else if (ItemID > 500 && ItemID < 601)
            {
                ItemType = "환금　　";
            }

            ItemName = name_;
            ItemPrice = price_;

            ItemAtk = atk_;
            ItemDef = def_;

            PlusStat = new int[5]; // str, tec, vit, wis, res
            PlusStat[0] = str_;
            PlusStat[1] = tec_;
            PlusStat[2] = vit_;
            PlusStat[3] = wis_;
            PlusStat[4] = res_;
        }
    }
}
