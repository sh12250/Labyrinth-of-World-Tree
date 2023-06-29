using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class DefeatBitishQuest : QuestBase
    {
        public DefeatBitishQuest()
        {
            Bitish value = new Bitish();

            SetQuestStatus("흉포한 생선들", value.Name, 10, 500, 500);
        }

        public override void SetQuestStatus(string name_, string target_, int targetNum_, int exp_, int gold_)
        {
            base.SetQuestStatus(name_, target_, targetNum_, exp_, gold_);
        }
        public override void PlusCount()
        {
            base.PlusCount();
        }
    }
}
