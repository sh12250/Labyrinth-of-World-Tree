using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabyrinthOfWorldTree
{
    public class DefeatDurianQuest : QuestBase
    {
        public DefeatDurianQuest()
        {
            Durian value = new Durian();

            SetQuestStatus("소중한 내 코", value.Name, 10, 630, 630);
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
