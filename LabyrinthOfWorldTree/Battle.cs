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

            for (int i = 0; i < monsterCount; i++)
            {
                Monsters.Add(MonsterBases[random.Next(0, 4)]);
            }
        }

        public void RunBattle(Player thePlayer)
        {
            int select = 0;

            Console.Clear();

            while (true)
            {
                if (Monsters.Count == 0)
                {

                    break;
                }

                for (int i = 0; i < Monsters.Count; i++)
                {
                    Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * i), 15);
                    Console.Write(Monsters[i].Name);
                    Console.SetCursorPosition((64 / (Monsters.Count + 1)) + ((64 / (Monsters.Count + 1)) * i), 16);
                    Console.Write("{0} / {1}", Monsters[i].Health, Monsters[i].MaxHealth);
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

                        if(Monsters[select].Health == 0)
                        {
                            Monsters.Remove(Monsters[select]);
                        }

                        Console.ReadLine();
                        Console.Clear();

                        break;
                }


            }           // while()
        }
    }
}
