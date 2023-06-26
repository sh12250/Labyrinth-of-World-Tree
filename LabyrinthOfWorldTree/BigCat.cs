using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class BigCat : MonsterBase
    {
        public BigCat() 
        {
            SetMonsterStatus("스라소니", 114, 13, 6, 181);
        }

        public override void SetMonsterStatus(string name_, int health_, int atk_, int def_, int exp_)
        {
            base.SetMonsterStatus(name_, health_, atk_, def_, exp_);
        }
        public override void RecieveDamage(int damage)
        {
            base.RecieveDamage(damage);
        }
    }
}
