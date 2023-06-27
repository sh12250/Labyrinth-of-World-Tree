using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Town
    {
        public Pub ThePub { get; private set; }
        public int Select { get; private set; }
        public char LastInput { get; private set; }


        public Town()
        {
            ThePub = new Pub();
        }


        public void TownScene(Player thePlayer)
        {
            LastInput = '0';
            Select = -1;

            int choice = 0;

            Console.Clear();

            while (true)
            {
                LastInput = '0';
                Select = -1;

                Console.SetCursorPosition(10, 15);
                Console.Write("상점");
                Console.SetCursorPosition(10, 16);
                Console.Write("주점");
                Console.SetCursorPosition(10, 17);
                Console.Write("미궁");

                Console.SetCursorPosition(8, 15 + choice);
                Console.Write("▷");

                Console.SetCursorPosition(0, 32);
                ConsoleKeyInfo input = Console.ReadKey();

                Console.SetCursorPosition(8, 15 + choice);
                Console.Write("　");

                switch (input.KeyChar)
                {
                    case 'w':
                    case 'W':
                    case 'ㅈ':
                        choice--;

                        if (choice == -1)
                        {
                            choice = 2;
                        }

                        Console.SetCursorPosition(8, 15 + choice);
                        Console.Write("▷");

                        break;
                    case 's':
                    case 'S':
                    case 'ㄴ':
                        choice++;

                        if (choice == 3)
                        {
                            choice = 0;
                        }

                        Console.SetCursorPosition(8, 15 + choice);
                        Console.Write("▷");

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        Console.SetCursorPosition(8, 15 + choice);
                        Console.Write("▶");

                        if(choice == 0)
                        {
                            Console.SetCursorPosition(10, 19);
                            Console.Write("상점에 들렀습니다");

                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if(choice == 1)
                        {
                            Console.SetCursorPosition(10, 19);
                            Console.Write("주점에 들렀습니다");

                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choice == 2)
                        {
                            Console.SetCursorPosition(10, 19);
                            Console.Write("미궁의 입구로 갑니다");

                            Console.ReadLine();
                            Console.Clear();
                        }

                        Select = choice;

                        break;
                    case 'q':
                    case 'Q':
                    case 'ㅂ':
                        Console.SetCursorPosition(10, 19);
                        Console.Write("게임을 종료합니다");

                        Console.ReadLine();
                        Console.Clear();

                        LastInput = 'q';

                        break;
                }

                if (LastInput == 'q')
                {
                    break;
                }

                if (Select == 1)
                {
                    Console.Clear();

                    choice = 0;

                    while (true)
                    {
                        LastInput = '0';
                        Select = -1;

                        Console.SetCursorPosition(10, 15);
                        Console.Write("퀘스트 수주");
                        Console.SetCursorPosition(10, 16);
                        Console.Write("퀘스트 보고");

                        Console.SetCursorPosition(8, 15 + choice);
                        Console.Write("▷");

                        Console.SetCursorPosition(0, 32);
                        input = Console.ReadKey();

                        Console.SetCursorPosition(8, 15 + choice);
                        Console.Write("　");

                        switch (input.KeyChar)
                        {
                            case 'w':
                            case 'W':
                            case 'ㅈ':
                                choice--;

                                if (choice == -1)
                                {
                                    choice = 1;
                                }

                                Console.SetCursorPosition(8, 15 + choice);
                                Console.Write("▷");

                                break;
                            case 's':
                            case 'S':
                            case 'ㄴ':
                                choice++;

                                if (choice == 2)
                                {
                                    choice = 0;
                                }

                                Console.SetCursorPosition(8, 15 + choice);
                                Console.Write("▷");

                                break;
                            case 'e':
                            case 'E':
                            case 'ㄷ':
                                Console.SetCursorPosition(8, 15 + choice);
                                Console.Write("▶");

                                if (choice == 0)
                                {
                                    Console.SetCursorPosition(10, 18);
                                    Console.Write("퀘스트를 받으러 갑니다");

                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (choice == 1)
                                {
                                    Console.SetCursorPosition(10, 18);
                                    Console.Write("퀘스트를 보고하러 갑니다");

                                    Console.ReadLine();
                                    Console.Clear();
                                }

                                Select = choice;

                                break;
                            case 'q':
                            case 'Q':
                            case 'ㅂ':
                                Console.SetCursorPosition(10, 18);
                                Console.Write("마을로 돌아갑니다");

                                Console.ReadLine();
                                Console.Clear();

                                LastInput = 'q';

                                break;
                        }

                        if (LastInput == 'q')
                        {
                            break;
                        }

                        if (Select == 0)
                        {
                            ThePub.SelectQuest(thePlayer.QuestList);

                            if (ThePub.PlayerQuestBoard != null)
                            {
                                thePlayer.SetQuestList(ThePub.PlayerQuestBoard);
                            }
                        }
                        else if (Select == 1)
                        {
                            ThePub.ReportQuest(thePlayer.QuestList);

                            if (ThePub.PlayerQuestBoard != null)
                            {
                                thePlayer.SetQuestList(ThePub.PlayerQuestBoard);
                            }
                        }
                    }
                }
            }           // while()
        }
    }
}
