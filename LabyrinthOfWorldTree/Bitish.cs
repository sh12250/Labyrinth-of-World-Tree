using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Bitish : MonsterBase
    {
        public override void SetMonsterStatus(string name_, int health_, int atk_, int def_, int exp_)
        {
            base.SetMonsterStatus("물어뜯치", 40, 5, 3, 38);
        }
    }
}
