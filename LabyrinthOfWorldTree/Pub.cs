using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Pub
    {
        public List<QuestBase> QuestBoard { get; private set; }
        public List<QuestBase> PlayerQuestBoard { get; private set; }
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

            PlayerQuestBoard = new List<QuestBase>();
        }


        public void ReportQuest(List<QuestBase> acceptedQuest)
        {
            if (acceptedQuest != null)
            {
                PlayerQuestBoard = null;
                PlayerQuestBoard = acceptedQuest;

                LastInput = '0';

                int curQuestNum = 0;

                Console.Clear();

                while (true)
                {
                    PrintQuestBoard(PlayerQuestBoard);

                    Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                    Console.Write("▷");

                    Console.SetCursorPosition(0, 32);
                    ConsoleKeyInfo input = Console.ReadKey();

                    Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                    Console.Write("　");

                    switch (input.KeyChar)
                    {
                        case 'w':
                        case 'W':
                        case 'ㅈ':
                            curQuestNum--;

                            if (curQuestNum == -1)
                            {
                                curQuestNum = PlayerQuestBoard.Count - 1;
                            }

                            Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                            Console.Write("▷");

                            break;
                        case 'a':
                        case 'A':
                        case 'ㅁ':
                            curQuestNum = 0;

                            Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                            Console.Write("▷");

                            break;
                        case 's':
                        case 'S':
                        case 'ㄴ':
                            curQuestNum++;

                            if (curQuestNum == PlayerQuestBoard.Count)
                            {
                                curQuestNum = 0;
                            }

                            Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                            Console.Write("▷");

                            break;
                        case 'd':
                        case 'D':
                        case 'ㅇ':
                            curQuestNum = PlayerQuestBoard.Count - 1;

                            Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                            Console.Write("▷");

                            break;
                        case 'e':
                        case 'E':
                        case 'ㄷ':
                            Console.SetCursorPosition(8, 16 - (PlayerQuestBoard.Count / 2) + curQuestNum);
                            Console.Write("▶");

                            SelectedQuestID = curQuestNum;

                            if (PlayerQuestBoard[curQuestNum].CurrentCount == PlayerQuestBoard[curQuestNum].TargetCount)
                            {
                                PlayerQuestBoard.Remove(PlayerQuestBoard[curQuestNum]);
                                Console.SetCursorPosition(10, 16 + (PlayerQuestBoard.Count / 2) + 2);
                                Console.Write("퀘스트를 달성했습니다");

                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.SetCursorPosition(10, 16 + (PlayerQuestBoard.Count / 2) + 2);
                                Console.Write("달성하지 못한 퀘스트입니다");

                                Console.ReadLine();
                                Console.Clear();
                            }

                            break;
                        case 'q':
                        case 'Q':
                        case 'ㅂ':
                            Console.SetCursorPosition(10, 16 + (PlayerQuestBoard.Count / 2) + 2);
                            Console.Write("주점으로 돌아갑니다");

                            Console.ReadLine();
                            Console.Clear();

                            LastInput = 'q';

                            break;
                    }

                    if(LastInput == 'q')
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine("퀘스트가 없습니다");

                Console.ReadLine();
                Console.Clear();
            }
        }

        public void SelectQuest(List<QuestBase> acceptedQuest)
        {
            if (acceptedQuest != null)
            {
                PlayerQuestBoard = null;
                PlayerQuestBoard = acceptedQuest;
            }

            SelectedQuestID = -1;

            LastInput = '0';

            int curQuestNum = 0;

            Console.Clear();

            while (true)
            {
                PrintQuestBoard(QuestBoard);

                Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                Console.Write("▷");

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

                        if (curQuestNum == -1)
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

                        if (curQuestNum == QuestBoard.Count)
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
                        Console.SetCursorPosition(8, 16 - (QuestBoard.Count / 2) + curQuestNum);
                        Console.Write("▶");

                        SelectedQuestID = curQuestNum;

                        if (PlayerQuestBoard.Contains(QuestBoard[curQuestNum]) == false)
                        {
                            PlayerQuestBoard.Add(QuestBoard[curQuestNum]);

                            Console.SetCursorPosition(10, 16 + (QuestBoard.Count / 2) + 2);
                            Console.Write("\"{0}\" 퀘스트를 받았습니다", QuestBoard[curQuestNum].QuestName);

                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 16 + (QuestBoard.Count / 2) + 2);
                            Console.Write("이미 수주한 퀘스트입니다");

                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;
                    case 'q':
                    case 'Q':
                    case 'ㅂ':
                        Console.SetCursorPosition(10, 16 + (QuestBoard.Count / 2) + 2);
                        Console.Write("주점으로 돌아갑니다");

                        Console.ReadLine();
                        Console.Clear();

                        LastInput = 'q';

                        break;
                }

                if (LastInput == 'q')
                {
                    break;
                }
            }           // while()
        }

        public void PrintQuestBoard(List<QuestBase> quests_)
        {
            for (int i = 0; i < quests_.Count; i++)
            {
                Console.SetCursorPosition(10, 16 - (quests_.Count / 2) + i);
                Console.WriteLine(quests_[i].QuestName);
            }
        }
    }
}
