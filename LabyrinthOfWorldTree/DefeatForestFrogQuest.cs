using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabyrinthOfWorldTree
{
    public class DefeatForestFrogQuest : QuestBase
    {
        public DefeatForestFrogQuest() 
        {
            ForestFrog value = new ForestFrog();

            SetQuestStatus("소음의 원인", value.Name, 10, 950);
        }

        public override void SetQuestStatus(string name_, string target_, int targetNum_, int exp_)
        {
            base.SetQuestStatus(name_, target_, targetNum_, exp_);
        }
    }
}
