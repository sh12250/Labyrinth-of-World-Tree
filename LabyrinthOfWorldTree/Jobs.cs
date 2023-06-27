using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Jobs
    {
        public string[] JobNames { get; private set; }
        public int[] StrUpRate { get; private set; }
        public int[] TecUpRate { get; private set; }
        public int[] VitUpRate { get; private set; }
        public int[] WisUpRate { get; private set; }
        public int[] LucUpRate { get; private set; }


        public Jobs()
        {
            JobNames = new string[] { "기사", "해적", "점성술사" };

            // 레벨업마다 스탯이 올라갈 확률
            // 각 300씩 설정 스킬을 추가하면 다시 설정할 필요가 있다
            StrUpRate = new int[] { 80, 60, 40 };
            TecUpRate = new int[] { 40, 80, 80 };
            VitUpRate = new int[] { 80, 40, 40 };
            WisUpRate = new int[] { 60, 40, 80 };
            LucUpRate = new int[] { 40, 80, 60 };
        }
    }
}
