using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Scenes
    {
        public int PickedJobID { get; private set; }

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

            ConsoleKeyInfo input = Console.ReadKey();

            PickedJobID = 1;

            while (true)
            {
                switch (PickedJobID)
                {
                    case 1:
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
                    case 2:
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
                    case 3:
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



                switch (input.KeyChar)
                {
                    case 'a':
                        PickedJobID--;

                        if (PickedJobID == 0)
                        {
                            PickedJobID = 3;
                        }

                        Console.WriteLine(value.JobNames[PickedJobID]);

                        break;
                    case 'd':
                        PickedJobID++;

                        if (PickedJobID == 4)
                        {
                            PickedJobID = 1;
                        }

                        Console.WriteLine(value.JobNames[PickedJobID]);

                        break;
                    case '\n':
                        Console.WriteLine(value.JobNames[PickedJobID] + "를 선택하셨습니다");
                        break;
                    default:
                        Console.WriteLine(value.JobNames[PickedJobID]);

                        break;
                }

                if (input.KeyChar == '\n')
                {
                    break;
                }
            }
        }
    }
}
