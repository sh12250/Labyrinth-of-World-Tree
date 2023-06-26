using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Scenes
    {
        public int SelectedJobID { get; private set; }

        public void TitleScene()
        {
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

            Console.WriteLine("　　　　　　　　　　　　　타이틀　씬　　　　　　　　　　　　　");

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

            Console.ReadLine();
            Console.Clear();
        }

        public void JobSelectScene()
        {
            Jobs value = new Jobs();
            int curJodID = 0;

            PrintCharacter(curJodID);

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();

                switch (input.KeyChar)
                {
                    case 'a':
                    case 'A':
                    case 'ㅁ':
                        curJodID -= 1;

                        if (curJodID == -1)
                        {
                            curJodID = 2;
                        }

                        break;
                    case 'd':
                    case 'D':
                    case 'ㅇ':
                        curJodID += 1;

                        if (curJodID == 3)
                        {
                            curJodID = 0;
                        }

                        break;
                    case 'e':
                    case 'E':
                    case 'ㄷ':
                        SelectedJobID = curJodID;

                        break;
                    default:
                        break;
                }

                PrintCharacter(curJodID);

                if (input.KeyChar == 'e' || input.KeyChar == 'E' || input.KeyChar == 'ㄷ')
                {
                    Console.WriteLine("{0}를 선택하셨습니다", value.JobNames[SelectedJobID]);

                    break;
                }
            }           // while()
        }

        public void PrintCharacter(int jobID)
        {
            switch (jobID)
            {
                case 0:
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

                    Console.WriteLine("　　　　　　　　　　　　　　기　사　　　　　　　　　　　　　　");

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

                    break;
                case 1:
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

                    Console.WriteLine("　　　　　　　　　　　　　　해　적　　　　　　　　　　　　　　");

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

                    break;
                case 2:
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

                    Console.WriteLine("　　　　　　　　　　　　점　성　술　사　　　　　　　　　　　　");

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

                    break;
            }
        }
    }
}
