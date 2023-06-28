﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Player
    {
        public List<QuestBase> QuestList { get; private set; }
        

        public string Name { get; private set; }
        public int JobID { get; private set; } // 직업 번호
        public int Level { get; private set; }
        public int MaxHealth { get; private set; } // 최대 체력
        public int Health { get; private set; } // 체력 0이 되면 죽는다
        // public int MaxMana { get; private set; }
        // public int Mana { get; private set; }
        public int Str { get; private set; } // 직접 공격력에 관여
        public int Tec { get; private set; } // 간접 공격력에 관여
        public int Vit { get; private set; } // 직접 방어력, 체력에 관여
        public int Wis { get; private set; } // 간접 방어력, ( 마력 )에 관여
        public int Luc { get; private set; } // 크리티컬, 회피에 관여

        public int MaxEXP { get; private set; }
        public int EXP { get; private set; }
        // public int Gold { get; private set; }


        public Player()
        {
            QuestList = new List<QuestBase>();
        }


        public void SetQuestList(List<QuestBase> theQuestBoard)
        {
            QuestList = null;

            if (theQuestBoard != null)
            {
                QuestList = theQuestBoard;
            }
        }

        public int GetDamage()
        {
            if(JobID == 0)
            {
                return Str + Vit;
            }
            else if(JobID == 1)
            {
                return Tec + Luc;
            }
            else if(JobID == 2)
            {
                return Tec + Wis;
            }

            return 0;
        }

        public void SetPlayerStatus()
        {
            switch (JobID)
            {
                case 0:
                    Str = 8;
                    Tec = 4;
                    Vit = 8;
                    Wis = 6;
                    Luc = 4;

                    break;
                case 1:
                    Str = 6;
                    Tec = 8;
                    Vit = 4;
                    Wis = 4;
                    Luc = 8;

                    break;
                case 2:
                    Str = 4;
                    Tec = 8;
                    Vit = 4;
                    Wis = 8;
                    Luc = 6;

                    break;
            }

            Level = 1;
            SetPlayerMaxHealth();
            Health = MaxHealth;
            MaxEXP = 100;
            EXP = 0;
        }

        public void LevelUpPlayer()
        {
            Jobs values = new Jobs();
            Random random = new Random();

            switch (JobID)
            {
                case 0:
                    if (random.Next(100) < values.StrUpRate[JobID])
                    {
                        Str += 1;
                    }

                    if (random.Next(100) < values.TecUpRate[JobID])
                    {
                        Tec += 1;
                    }

                    if (random.Next(100) < values.VitUpRate[JobID])
                    {
                        Vit += 1;
                    }

                    if (random.Next(100) < values.WisUpRate[JobID])
                    {
                        Luc += 1;
                    }

                    if (random.Next(100) < values.LucUpRate[JobID])
                    {
                        Wis += 1;
                    }

                    break;
                case 1:
                    if (random.Next(100) < values.StrUpRate[JobID])
                    {
                        Str += 1;
                    }

                    if (random.Next(100) < values.TecUpRate[JobID])
                    {
                        Tec += 1;
                    }

                    if (random.Next(100) < values.VitUpRate[JobID])
                    {
                        Vit += 1;
                    }

                    if (random.Next(100) < values.WisUpRate[JobID])
                    {
                        Luc += 1;
                    }

                    if (random.Next(100) < values.LucUpRate[JobID])
                    {
                        Wis += 1;
                    }

                    break;
                case 2:
                    if (random.Next(100) < values.StrUpRate[JobID])
                    {
                        Str += 1;
                    }

                    if (random.Next(100) < values.TecUpRate[JobID])
                    {
                        Tec += 1;
                    }

                    if (random.Next(100) < values.VitUpRate[JobID])
                    {
                        Vit += 1;
                    }

                    if (random.Next(100) < values.WisUpRate[JobID])
                    {
                        Luc += 1;
                    }

                    if (random.Next(100) < values.LucUpRate[JobID])
                    {
                        Wis += 1;
                    }

                    break;
            }

            SetPlayerMaxHealth();
            Health = MaxHealth;
            EXP -= MaxEXP;
            MaxEXP += (int)(MaxEXP * 0.1f);
        }

        public void SetPlayerMaxHealth()
        {
            MaxHealth = 100 + Vit * 5 + (Level - 1) * 5; 
        }

        public void SetPlayerName()
        {
            Console.SetCursorPosition(21, 14);
            Console.WriteLine("이름을　정해주세요");
            Console.SetCursorPosition(21, 16);
            string nameInput = Console.ReadLine();
            Name = nameInput;

            if (Name == "")
            {
                Name = "당신";
            }
        }

        public void SetPlayerJobID(int jobNum)
        {
            JobID = jobNum;
        }

        public void RecieveDamage(int damage)
        {
            damage -= Vit * 2;

            if (damage <= 0)
            {
                damage = 1;
            }

            Health -= damage;

            if(Health <= 0)
            {
                Health = 0;
            }
        }
    }
}

