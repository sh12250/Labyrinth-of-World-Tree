using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Pub
    {
        public List<QuestBase> QuestBoard { get; private set; }
        public int SelectedQuestID { get; private set; }
        public char LastInput { get; private set; }

        public Pub()
        {
            QuestBoard = new List<QuestBase>
            {
                new DefeatBitishQuest(),
                new DefeatDurianQuest(),
                new DefeatForestFrogQuest(),
                new DefeatBigCatQuest()
            };
        }

        public void SelectQuest()
        {
            SelectedQuestID = -1;

            int curQuestNum = 0;

            Console.Clear();
            PrintQuestBoard();

            while (true)
            {
                Console.SetCursorPosition(0, 32);
                ConsoleKeyInfo input = Console.ReadKey();

                Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                Console.Write("　");

                switch (input.KeyChar)
                {
                    case 'w':
                    case 'W':
                    case 'ㅈ':
                        curQuestNum--;

                        if(curQuestNum == -1)
                        {
                            curQuestNum = QuestBoard.Count - 1;
                        }

                        Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                        Console.Write("▷");

                        break;
                    case 'a':
                    case 'A':
                    case 'ㅁ':
                        curQuestNum = 0;

                        Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                        Console.Write("▷");

                        break;
                    case 's':
                    case 'S':
                    case 'ㄴ':
                        curQuestNum++;

                        if(curQuestNum == QuestBoard.Count)
                        {
                            curQuestNum = 0;
                        }

                        Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                        Console.Write("▷");

                        break;
                    case 'd':
                    case 'D':
                    case 'ㅇ':
                        curQuestNum = QuestBoard.Count - 1;

                        Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                        Console.Write("▷");

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        SelectedQuestID = curQuestNum;

                        Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                        Console.Write("▶");

                        break;
                    case 'q':
                    case 'Q':
                    case 'ㅂ':
                        LastInput = 'q';

                        break;
                }

                if (LastInput == 'q')
                {
                    break;
                }
            }           // while()
        }

        public void PrintQuestBoard()
        {
            for (int i = 0; i < QuestBoard.Count; i++)
            {
                Console.SetCursorPosition(10, 16 - (QuestBoard.Count / 2) + i);
                Console.WriteLine(QuestBoard[i].QuestName);
            }
        }
    }
}
