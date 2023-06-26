using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class DefeatBigCatQuest : QuestBase
    {
        public DefeatBigCatQuest() 
        {
            BigCat value = new BigCat();

            SetQuestStatus("초보살해자", value.Name, 1, 1000);
        }

        public override void SetQuestStatus(string name_, string target_, int targetNum_, int exp_)
        {
            base.SetQuestStatus(name_, target_, targetNum_, exp_);
        }
    }
}
