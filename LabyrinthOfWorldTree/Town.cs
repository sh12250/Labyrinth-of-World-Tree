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
        public Shop TheShop { get; private set; }
        public int Select { get; private set; }
        public char LastInput { get; private set; }


        public Town()
        {
            ThePub = new Pub();
            TheShop = new Shop();
        }


        public void TownScene(Player thePlayer)
        {
            LastInput = '0';
            Select = -1;
            thePlayer.SetPlayerMaxHealth();

            int choice = 0;

            Console.Clear();

            while (true)        // 마을
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

                        break;
                    case 's':
                    case 'S':
                    case 'ㄴ':
                        choice++;

                        if (choice == 3)
                        {
                            choice = 0;
                        }

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        Console.SetCursorPosition(8, 15 + choice);
                        Console.Write("▶");

                        if (choice == 0)
                        {
                            Console.SetCursorPosition(10, 19);
                            Console.Write("상점에 들렀습니다");

                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choice == 1)
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

                if (Select == 0)
                {
                    Console.Clear();

                    choice = 0;

                    while (true) // 상점
                    {
                        Console.SetCursorPosition(10, 15);
                        Console.Write("아이템 구매");
                        Console.SetCursorPosition(10, 16);
                        Console.Write("아이템 판매");

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
                                choice -= 1;

                                if (choice == -1)
                                {
                                    choice = 1;
                                }

                                break;
                            case 's':
                            case 'S':
                            case 'ㄴ':
                                choice += 1;

                                if (choice == 2)
                                {
                                    choice = 0;
                                }

                                break;
                            case 'e':
                            case 'E':
                            case 'ㄷ':
                                Console.SetCursorPosition(8, 15 + choice);
                                Console.Write("▶");

                                if (choice == 0)
                                {
                                    Console.SetCursorPosition(10, 18);
                                    Console.Write("아이템을 구매하러 갑니다");

                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (choice == 1)
                                {
                                    Console.SetCursorPosition(10, 18);
                                    Console.Write("아이템을 판매하러 갑니다");

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

                        if(Select == 0)
                        {
                            TheShop.BuyItem(thePlayer);
                        }
                    }
                }
                else if (Select == 1)
                {
                    Console.Clear();

                    choice = 0;

                    while (true)        // 주점
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
                    }           // while() 주점
                }
                else if (Select == 2)
                {
                    while (true)
                    {
                        LastInput = '0';
                        Select = -1;

                        choice = 0;

                        Console.SetCursorPosition(10, 16);
                        Console.Write("미궁 1층");

                        Console.SetCursorPosition(8, 16 + choice);
                        Console.Write("▷");

                        Console.SetCursorPosition(0, 32);
                        input = Console.ReadKey();

                        Console.SetCursorPosition(8, 16 + choice);
                        Console.Write("　");

                        switch (input.KeyChar)
                        {
                            case 'w':
                            case 'W':
                            case 'ㅈ':
                                choice--;

                                if (choice == -1)
                                {
                                    choice = 0;
                                }

                                break;
                            case 's':
                            case 'S':
                            case 'ㄴ':
                                choice++;

                                if (choice == 1)
                                {
                                    choice = 0;
                                }

                                break;
                            case 'e':
                            case 'E':
                            case 'ㄷ':
                                Console.SetCursorPosition(8, 16 + choice);
                                Console.Write("▶");

                                Console.WriteLine("미궁 1층에 입장합니다");

                                Select = choice;

                                break;
                            case 'q':
                            case 'Q':
                            case 'ㅂ':
                                Console.SetCursorPosition(10, 19);
                                Console.Write("마을로 들어갑니다");

                                Console.ReadLine();
                                Console.Clear();

                                LastInput = 'q';

                                break;
                        }

                        if (Select == 0)
                        {
                            RandomMap map = new RandomMap();
                            Random random = new Random();
                            Battle battle = new Battle();

                            int direction = 0; // 0 : ↑, 1 : ←, 2 : ↓, 3 : →

                            int nextX = map.PlayerXPos;
                            int nextY = map.PlayerYPos;

                            int incountRate = 0;

                            PrintCharacterView();

                            while (true)        // 탐험
                            {
                                map.PrintTheMap();

                                Console.SetCursorPosition(0, 32);
                                input = Console.ReadKey();

                                switch (input.KeyChar)
                                {
                                    case 'w':
                                    case 'W':
                                    case 'ㅈ':
                                        switch (direction)
                                        {
                                            case 0:
                                                if (map.theMap[nextY - 1, nextX] == map.Blank)
                                                {
                                                    nextY -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY - 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 1:
                                                if (map.theMap[nextY, nextX - 1] == map.Blank)
                                                {
                                                    nextX -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX - 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 2:
                                                if (map.theMap[nextY + 1, nextX] == map.Blank)
                                                {
                                                    nextY += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY + 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 3:
                                                if (map.theMap[nextY, nextX + 1] == map.Blank)
                                                {
                                                    nextX += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX + 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                        }

                                        break;
                                    case 'a':
                                    case 'A':
                                    case 'ㅁ':
                                        direction += 1;

                                        if (direction == 4)
                                        {
                                            direction = 0;
                                        }

                                        break;
                                    case 's':
                                    case 'S':
                                    case 'ㄴ':
                                        switch (direction)
                                        {
                                            case 0:
                                                if (map.theMap[nextY + 1, nextX] == map.Blank)
                                                {
                                                    nextY += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY + 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 1:
                                                if (map.theMap[nextY, nextX + 1] == map.Blank)
                                                {
                                                    nextX += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX + 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 2:
                                                if (map.theMap[nextY - 1, nextX] == map.Blank)
                                                {
                                                    nextY -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY - 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 3:
                                                if (map.theMap[nextY, nextX - 1] == map.Blank)
                                                {
                                                    nextX -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX - 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                        }

                                        break;
                                    case 'd':
                                    case 'D':
                                    case 'ㅇ':
                                        direction -= 1;

                                        if (direction == -1)
                                        {
                                            direction = 3;
                                        }

                                        break;
                                    case 'q':
                                    case 'Q':
                                    case 'ㅂ':
                                        switch (direction)
                                        {
                                            case 0:
                                                if (map.theMap[nextY, nextX - 1] == map.Blank)
                                                {
                                                    nextX -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX - 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 1:
                                                if (map.theMap[nextY + 1, nextX] == map.Blank)
                                                {
                                                    nextY += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY + 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 2:
                                                if (map.theMap[nextY, nextX + 1] == map.Blank)
                                                {
                                                    nextX += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX + 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 3:
                                                if (map.theMap[nextY - 1, nextX] == map.Blank)
                                                {
                                                    nextY -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY - 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                        }
                                        break;
                                    case 'e':
                                    case 'E':
                                    case 'ㄷ':
                                        switch (direction)
                                        {
                                            case 0:
                                                if (map.theMap[nextY, nextX + 1] == map.Blank)
                                                {
                                                    nextX += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX + 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 1:
                                                if (map.theMap[nextY - 1, nextX] == map.Blank)
                                                {
                                                    nextY -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY - 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 2:
                                                if (map.theMap[nextY, nextX - 1] == map.Blank)
                                                {
                                                    nextX -= 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY, nextX - 1] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                            case 3:
                                                if (map.theMap[nextY + 1, nextX] == map.Blank)
                                                {
                                                    nextY += 1;
                                                    map.SetPlayerPosition(nextX, nextY);
                                                    incountRate += random.Next(1, 11);
                                                }
                                                else if (map.theMap[nextY + 1, nextX] == map.UpStair)
                                                {
                                                    LastInput = 'q';
                                                }

                                                break;
                                        }
                                        break;
                                }

                                if (incountRate >= 100)
                                {
                                    battle.SetMonsters();
                                    battle.RunBattle(thePlayer);

                                    incountRate -= 100;
                                }

                                if (LastInput == 'q')
                                {
                                    Console.Clear();
                                    break;
                                }
                            }           // while() 탐험
                        }

                        if (LastInput == 'q')
                        {
                            break;
                        }
                    }
                }
            }           // while() 마을
        }           // TownScene()

        public void PrintCharacterView()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");

            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");

            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");

            Console.WriteLine("　　　　　　　　　　　　　　시　야　　　　　　　　　　　　　　");

            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");

            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");

            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
            Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
        }
    }
}
