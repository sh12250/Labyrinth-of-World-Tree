using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class QuestBase
    {
        public string QuestName { get; private set; }
        public string TargetName { get; private set; }
        public int TargetCount { get; private set; }
        public int CurrentCount { get; private set; }
        public int RewardEXP { get; private set; }
        public int RewardGold { get; private set; }

        public virtual void SetQuestStatus(string name_, string target_, int targetNum_, int exp_, int gold_)
        {
            QuestName = name_;
            TargetName = target_;
            TargetCount = targetNum_;
            CurrentCount = 0;
            RewardEXP = exp_;
            RewardGold = gold_;
        }

        public virtual void PlusCount()
        {
            CurrentCount++;
        }
    }
}
