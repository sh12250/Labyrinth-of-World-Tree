using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Jobs
    {
        public string[] jobNames = new string[] { "기사", "해적", "점성술사" };
        // 레벨업마다 스탯이 올라갈 확률
        // 각 300씩 설정 스킬을 추가하면 다시 설정할 필요가 있다
        public int[] strUpRate = new int[] { 80, 60, 10 };
        public int[] tecUpRate = new int[] { 60, 80, 80 };
        public int[] vitUpRate = new int[] { 80, 60, 40 };
        public int[] wisUpRate = new int[] { 40, 50, 80 };
        public int[] lucUpRate = new int[] { 40, 80, 80 };
    }
}
