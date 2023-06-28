using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Battle
    {
        public List<MonsterBase> MonsterBases { get; private set; }
        public List<MonsterBase> Monsters { get; private set; }


        public Battle()
        {
            MonsterBases = new List<MonsterBase>
            {
                new Bitish(),
                new Durian(),
                new ForestFrog(),
                new BigCat()
            };

            Monsters = new List<MonsterBase>();
        }


        public void SetMonsters()
        {
            Random random = new Random();
            Monsters.Clear();

            int monsterCount = random.Next(1, 4);

            int randIdx = 0;

            for (int i = 0; i < monsterCount; i++)
            {
                randIdx = random.Next(0, 4);
                Monsters.Add(new MonsterBase());
                Monsters[i].SetMonsterStatus(MonsterBases[randIdx].Name, MonsterBases[randIdx].Health, MonsterBases[randIdx].Atk, MonsterBases[randIdx].Def, MonsterBases[randIdx].Exp);
            }
        }

        public void RunBattle(Player thePlayer)
        {
            int select = 0;

            Console.Clear();

            while (true)
            {
                if (Monsters.Count == 0 || thePlayer.Health == 0)
                {
                    break;
                }

                for (int i = 0; i < Monsters.Count; i++)
                {
                    Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * i), 15);
                    Console.Write(Monsters[i].Name);
                    Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * i), 16);
                    Console.Write("{0} / {1}", Monsters[i].Health, Monsters[i].MaxHealth);

                    Console.SetCursorPosition(30, 30);
                    Console.Write(thePlayer.Name);
                    Console.SetCursorPosition(30, 31);
                    Console.Write("{0} / {1}", thePlayer.Health, thePlayer.MaxHealth);
                }

                Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * select), 18);
                Console.Write("△");

                Console.SetCursorPosition(0, 32);
                ConsoleKeyInfo input = Console.ReadKey();

                Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * select), 18);
                Console.Write("　");


                switch (input.KeyChar)
                {
                    case 'a':
                    case 'A':
                    case 'ㅁ':
                        select--;

                        if(select == -1)
                        {
                            select = Monsters.Count - 1;
                        }

                        Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * select), 18);
                        Console.Write("△");

                        break;
                    case 'd':
                    case 'D':
                    case 'ㅇ':
                        select++;

                        if (select == Monsters.Count)
                        {
                            select = 0;
                        }

                        Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * select), 18);
                        Console.Write("△");

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * select), 18);
                        Console.Write("▲");

                        Monsters[select].RecieveDamage(thePlayer.GetDamage());

                        Console.SetCursorPosition(24, 24);
                        Console.Write("{0}을 공격했다", Monsters[select].Name);

                        Console.SetCursorPosition(24, 25);
                        Console.Write("{0}에게 {1}의 데미지를 입혔다", Monsters[select].Name, thePlayer.GetDamage() - Monsters[select].Def);

                        Console.ReadLine();
                        Console.Clear();

                        if (Monsters[select].Health == 0)
                        {
                            if(thePlayer.QuestList.Count > 0)
                            {
                                for(int i = 0; i < thePlayer.QuestList.Count; i++)
                                {
                                    if (thePlayer.QuestList[i].TargetName == Monsters[select].Name)
                                    {
                                        thePlayer.QuestList[i].PlusCount();
                                        Console.Write("{0}", thePlayer.QuestList[i].CurrentCount);
                                    }
                                }
                            }

                            Monsters.Remove(Monsters[select]);
                        }

                        for(int i = 0; i < Monsters.Count; i++)
                        {
                            int monsterDamage = Monsters[i].Atk - (thePlayer.Vit * 2);

                            if(monsterDamage <= 0)
                            {
                                monsterDamage = 1;
                            }

                            Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * i), 15);
                            Console.Write(Monsters[i].Name);
                            Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * i), 16);
                            Console.Write("{0} / {1}", Monsters[i].Health, Monsters[i].MaxHealth);

                            Console.SetCursorPosition(30, 30);
                            Console.Write(thePlayer.Name);
                            Console.SetCursorPosition(30, 31);
                            Console.Write("{0} / {1}", thePlayer.Health, thePlayer.MaxHealth);

                            thePlayer.RecieveDamage(Monsters[i].Atk);

                            Console.SetCursorPosition(24, 24);
                            Console.Write("{0}의 공격", Monsters[i].Name);

                            Console.SetCursorPosition(24, 25);
                            Console.Write("{0}에게 {1}의 데미지를 입었다", Monsters[i].Name, monsterDamage);

                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;
                }

                if(thePlayer.Health == 0)
                {
                    break;
                }

            }           // while()
        }
    }
}
