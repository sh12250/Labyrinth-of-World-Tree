using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Durian : MonsterBase
    {
        public override void SetMonsterStatus(string name_, int health_, int atk_, int def_, int exp_)
        {
            base.SetMonsterStatus("괴물두리안", 48, 4, 5, 48);
        }
        public override void RecieveDamage(int damage)
        {
            base.RecieveDamage(damage);
        }
    }
}
