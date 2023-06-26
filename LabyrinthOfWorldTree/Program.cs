using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(125, 40);

            TitleScene scene = new TitleScene();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
