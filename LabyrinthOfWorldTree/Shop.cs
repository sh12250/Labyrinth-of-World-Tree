using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Shop : Item
    {
        public int Select { get; private set; }

        public char LastInput { get; private set; }

        public Shop()
        {

        }

        public void BuyItem(Player thePlayer)
        {
            ConsoleKeyInfo input;
            int choice = 0;
            int idx = 0;

            LastInput = '0';

            Console.Clear();

            while (true)
            {
                Console.SetCursorPosition(10, 12);
                Console.Write("종류　　　이름　　　　　　　　가격");

                for (int i = 0; i < 5; i++)
                {
                    if (Items[idx + i].ItemPrice < 100)
                    {
                        Console.SetCursorPosition(10, 14 + i);
                        Console.Write("{0}　{1}　{2} ", Items[idx + i].ItemType, Items[idx + i].ItemName, Items[idx + i].ItemPrice);
                    }
                    else
                    {
                        Console.SetCursorPosition(10, 14 + i);
                        Console.Write("{0}　{1}　{2}", Items[idx + i].ItemType, Items[idx + i].ItemName, Items[idx + i].ItemPrice);
                    }
                }

                Console.SetCursorPosition(8, 14 + choice);
                Console.Write("▷");

                Console.SetCursorPosition(0, 32);
                input = Console.ReadKey();

                Console.SetCursorPosition(8, 14 + choice);
                Console.Write("　");

                switch (input.KeyChar)
                {
                    case 'w':
                    case 'W':
                    case 'ㅈ':
                        choice -= 1;

                        if (choice < 0)
                        {
                            if (idx == 0)
                            {
                                choice = 4;
                                idx = 13;
                            }
                            else
                            {
                                choice = 0;
                                idx -= 1;
                            }
                        }

                        break;
                    case 'a':
                    case 'A':
                    case 'ㅁ':
                        if (choice != 0)
                        {
                            choice = 0;
                        }
                        else
                        {
                            idx -= 5;

                            if (idx < 0)
                            {
                                idx = 0;
                            }
                        }

                        break;
                    case 's':
                    case 'S':
                    case 'ㄴ':
                        choice += 1;

                        if (choice > 4)
                        {
                            if (idx == 13)
                            {
                                choice = 0;
                                idx = 0;
                            }
                            else
                            {
                                choice = 4;
                                idx += 1;
                            }
                        }

                        break;
                    case 'd':
                    case 'D':
                    case 'ㅇ':
                        if (choice != 4)
                        {
                            choice = 4;
                        }
                        else
                        {
                            idx += 5;

                            if (idx > 13)
                            {
                                idx = 13;
                            }
                        }

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        Console.SetCursorPosition(8, 14 + choice);
                        Console.Write("▶");

                        if (thePlayer.Gold >= Items[idx + choice].ItemPrice)
                        {
                            thePlayer.Inven.PlusItemCount(Items[idx + choice].ItemName);

                            Console.SetCursorPosition(10, 20);
                            Console.Write("{0}를 구입했습니다", Items[idx + choice].ItemName);

                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.Write("골드가 부족합니다");

                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;
                    case 'q':
                    case 'Q':
                    case 'ㅂ':
                        Console.SetCursorPosition(10, 20);
                        Console.Write("상점으로 돌아갑니다");

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

        public void SellItem(Player thePlayer)
        {
            ConsoleKeyInfo input;
            int choice = 0;
            int idx = 0;

            LastInput = '0';

            Console.Clear();

            while (true)
            {
                Console.SetCursorPosition(10, 12);
                Console.Write("종류　　　이름　　　　　　　　갯수");

                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(10, 14 + i);
                    Console.Write("{0}　{1}　{2}", Items[idx + i].ItemType, Items[idx + i].ItemName, Items[idx + i].ItemPrice);
                }

                Console.SetCursorPosition(8, 14 + choice);
                Console.Write("▷");

                Console.SetCursorPosition(0, 32);
                input = Console.ReadKey();

                Console.SetCursorPosition(8, 14 + choice);
                Console.Write("　");

                switch (input.KeyChar)
                {
                    case 'w':
                    case 'W':
                    case 'ㅈ':
                        choice -= 1;

                        if (choice < 0)
                        {
                            if (idx == 0)
                            {
                                choice = 4;
                                idx = 13;
                            }
                            else
                            {
                                choice = 0;
                                idx -= 1;
                            }
                        }

                        break;
                    case 'a':
                    case 'A':
                    case 'ㅁ':
                        if (choice != 0)
                        {
                            choice = 0;
                        }
                        else
                        {
                            idx -= 5;

                            if (idx < 0)
                            {
                                idx = 0;
                            }
                        }

                        break;
                    case 's':
                    case 'S':
                    case 'ㄴ':
                        choice += 1;

                        if (choice > 4)
                        {
                            if (idx == 13)
                            {
                                choice = 0;
                                idx = 0;
                            }
                            else
                            {
                                choice = 4;
                                idx += 1;
                            }
                        }

                        break;
                    case 'd':
                    case 'D':
                    case 'ㅇ':
                        if (choice != 4)
                        {
                            choice = 4;
                        }
                        else
                        {
                            idx += 5;

                            if (idx > 13)
                            {
                                idx = 13;
                            }
                        }

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        Console.SetCursorPosition(8, 14 + choice);
                        Console.Write("▶");

                        if (thePlayer.Gold >= Items[idx + choice].ItemPrice)
                        {
                            thePlayer.Inven.PlusItemCount(Items[idx + choice].ItemName);

                            Console.SetCursorPosition(10, 20);
                            Console.Write("{0}를 구입했습니다", Items[idx + choice].ItemName);

                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.Write("골드가 부족합니다");

                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;
                    case 'q':
                    case 'Q':
                    case 'ㅂ':
                        Console.SetCursorPosition(10, 20);
                        Console.Write("상점으로 돌아갑니다");

                        Console.ReadLine();
                        Console.Clear();

                        LastInput = 'q';

                        break;
                }

                if (LastInput == 'q')
                {
                    break;
                }
            }
        }
    }
}
