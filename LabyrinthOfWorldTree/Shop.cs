using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
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

                Console.SetCursorPosition(10, 5);
                Console.Write("소지금 : {0}", thePlayer.Gold);

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
                            thePlayer.Inven.PlusItemCount(idx + choice);

                            Console.SetCursorPosition(10, 20);
                            Console.Write("{0}를 구입했습니다", Items[idx + choice].ItemName);

                            thePlayer.MinusPlayerGold(Items[idx + choice].ItemPrice);

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
            List<int> itemIds = new List<int>();
            int choice = 0;
            int idx = 0;
            int count = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                if (thePlayer.Inven.IdxAndCount[i] > 0)
                {
                    itemIds.Add(i);
                    count++;
                }

                itemIds.Sort();
            }

            LastInput = '0';

            Console.Clear();

            while (true)
            {
                if (count == 0)
                {
                    Console.SetCursorPosition(10, 20);
                    Console.Write("소지한 아이템이 없습니다");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                }

                Console.SetCursorPosition(10, 12);
                Console.Write("종류　　　이름　　　　　　　　갯수");
                if (count <= 5)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (thePlayer.Inven.IdxAndCount[itemIds[idx + i]] < 10)
                        {
                            Console.SetCursorPosition(10, 14 + i);
                            Console.Write("{0}　{1}　 {2}", Items[itemIds[idx + i]].ItemType, Items[itemIds[idx + i]].ItemName, thePlayer.Inven.IdxAndCount[itemIds[idx + i]]);
                        }
                        else if (thePlayer.Inven.IdxAndCount[itemIds[idx + i]] < 100)
                        {
                            Console.SetCursorPosition(10, 14 + i);
                            Console.Write("{0}　{1}　  {2}", Items[itemIds[idx + i]].ItemType, Items[itemIds[idx + i]].ItemName, thePlayer.Inven.IdxAndCount[itemIds[idx + i]]);
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 14 + i);
                            Console.Write("{0}　{1}　{2}", Items[itemIds[idx + i]].ItemType, Items[itemIds[idx + i]].ItemName, thePlayer.Inven.IdxAndCount[itemIds[idx + i]]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (thePlayer.Inven.IdxAndCount[itemIds[idx + i]] < 10)
                        {
                            Console.SetCursorPosition(10, 14 + i);
                            Console.Write("{0}　{1}　 {2}", Items[itemIds[idx + i]].ItemType, Items[itemIds[idx + i]].ItemName, thePlayer.Inven.IdxAndCount[itemIds[idx + i]]);
                        }
                        else if (thePlayer.Inven.IdxAndCount[itemIds[idx + i]] < 100)
                        {
                            Console.SetCursorPosition(10, 14 + i);
                            Console.Write("{0}　{1}　  {2}", Items[itemIds[idx + i]].ItemType, Items[itemIds[idx + i]].ItemName, thePlayer.Inven.IdxAndCount[itemIds[idx + i]]);
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 14 + i);
                            Console.Write("{0}　{1}　{2}", Items[itemIds[idx + i]].ItemType, Items[itemIds[idx + i]].ItemName, thePlayer.Inven.IdxAndCount[itemIds[idx + i]]);
                        }
                    }
                }

                if (choice > count - 1)
                {
                    choice = count - 1;
                }

                Console.SetCursorPosition(10, 5);
                Console.Write("소지금 : {0}", thePlayer.Gold);

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

                        if (count > 4)
                        {
                            if (choice < 0)
                            {
                                if (idx == 0)
                                {
                                    choice = 4;
                                    idx = count - 5;
                                }
                                else
                                {
                                    choice = 0;
                                    idx -= 1;
                                }
                            }
                        }
                        else if (count == 4)
                        {
                            if (choice < 0)
                            {
                                if (idx == 0)
                                {
                                    choice = 3;
                                    idx = 0;
                                }
                                else
                                {
                                    choice = 0;
                                    idx = 0;
                                }
                            }
                        }
                        else if (count == 3)
                        {
                            if (choice < 0)
                            {
                                if (idx == 0)
                                {
                                    choice = 2;
                                    idx = 0;
                                }
                                else
                                {
                                    choice = 0;
                                    idx = 0;
                                }
                            }
                        }
                        else if (count == 2)
                        {
                            if (choice < 0)
                            {
                                if (idx == 0)
                                {
                                    choice = 1;
                                    idx = 0;
                                }
                                else
                                {
                                    choice = 0;
                                    idx = 0;
                                }
                            }
                        }
                        else if (count == 1)
                        {
                            if (choice < 0)
                            {
                                if (idx == 0)
                                {
                                    choice = 0;
                                    idx = 0;
                                }
                                else
                                {
                                    choice = 0;
                                    idx = 0;
                                }
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

                        if (count > 4)
                        {
                            if (choice > 4)
                            {
                                if (idx == count - 5)
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
                        }
                        else if (count == 4)
                        {
                            if (choice > 3)
                            {
                                choice = 0;
                            }
                            idx = 0;
                        }
                        else if (count == 3)
                        {
                            if (choice > 2)
                            {
                                choice = 0;
                            }

                            idx = 0;
                        }
                        else if (count == 2)
                        {
                            if (choice > 1)
                            {
                                choice = 0;
                            }

                            idx = 0;
                        }
                        else if (count == 1)
                        {
                            choice = 0;
                            idx = 0;
                        }

                        break;
                    case 'd':
                    case 'D':
                    case 'ㅇ':
                        if (count > 4)
                        {
                            if (choice != 4)
                            {
                                choice = 4;
                            }
                            else
                            {
                                idx += 5;

                                if (idx > count - 5)
                                {
                                    idx = count - 5;
                                }
                            }
                        }
                        else
                        {
                            if (choice != count - 1)
                            {
                                choice = count - 1;
                            }
                            else
                            {
                                idx += 5;

                                if (idx > count - 5)
                                {
                                    idx = count - 5;
                                }
                            }
                        }

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        Console.SetCursorPosition(8, 14 + choice);
                        Console.Write("▶");

                        Console.SetCursorPosition(10, 20);
                        Console.Write("{0}를 판매했습니다", Items[itemIds[idx + choice]].ItemName);

                        thePlayer.PlusPlayerGold(Items[itemIds[idx + choice]].ItemPrice / 2);

                        thePlayer.Inven.MinusItemCount(itemIds[idx + choice]);

                        if (thePlayer.Inven.IdxAndCount[itemIds[idx + choice]] == 0)
                        {
                            itemIds.Remove(itemIds[idx + choice]);
                            count -= 1;
                        }

                        Console.ReadLine();
                        Console.Clear();

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
