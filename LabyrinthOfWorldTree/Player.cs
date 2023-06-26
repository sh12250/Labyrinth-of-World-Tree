using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Player
    {
        public int JobID { get; private set; }
        public int hp { get; private set; }
        // public int mp
        public int str { get; private set; } // 직접 공격력에 관여
        public int tec { get; private set; } // 간접 공격력에 관여
        public int vit { get; private set; } // 직접 방어력, 체력에 관여
        public int wis { get; private set; } // 간접 방어력, ( 마력 )에 관여
        public int luc { get; private set; } // 크리티컬, 회피에 관여
    }                                       
}                                           
                                            
                                            