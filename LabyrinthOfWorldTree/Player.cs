using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Player
    {
        public string Name {  get; private set; }
        public int JobID { get; private set; } // 직업 번호
        public int Health { get; private set; } // 체력 0이 되면 죽는다
        // public int mp
        public int Str { get; private set; } // 직접 공격력에 관여
        public int Tec { get; private set; } // 간접 공격력에 관여
        public int Vit { get; private set; } // 직접 방어력, 체력에 관여
        public int Wis { get; private set; } // 간접 방어력, ( 마력 )에 관여
        public int Luc { get; private set; } // 크리티컬, 회피에 관여

        public int MaxEXP { get; private set; }
        public int EXP { get; private set; }


        public Player()
        {
            SetPlayerName();
        }

        public void SetPlayerStatus()
        {
            Health = 50;

            switch (JobID)
            {
                case 1:
                    Str = 8;
                    Tec = 4;
                    Vit = 8;
                    Wis = 6;
                    Luc = 4;

                    break;
                case 2:
                    Str = 6;
                    Tec = 8;
                    Vit = 4;
                    Wis = 4;
                    Luc = 8;

                    break;
                case 3:
                    Str = 4;
                    Tec = 8;
                    Vit = 4;
                    Wis = 8;
                    Luc = 6;

                    break;
            }

            Health += Vit * 5;

            MaxEXP = 100;
            EXP = 0;

        }



        public void LevelUpPlayer()
        {
            Jobs values = new Jobs();
            Random random = new Random();

            EXP -= MaxEXP;

            Str += 1;
            Tec += 1;
            Vit += 1;
            Wis += 1;
            Luc += 1;

            switch(JobID)
            {
                case 1:
                    if(random.Next(100) < values.StrUpRate[JobID])
                    {
                        Str += 1;
                    }

                    if(random.Next(100) < values.TecUpRate[JobID])
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
                case 3:
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
        }

        public void SetPlayerName()
        {
            string nameInput = Console.ReadLine();
            Name = nameInput;
        }

        public void SetPlayerJobID(int jobNum)
        {
            JobID = jobNum;
        }
    }                                       
}                                           
                                            
                                            