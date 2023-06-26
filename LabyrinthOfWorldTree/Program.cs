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
            Console.CursorVisible = false;

            Scenes scenes = new Scenes();
            Player player = new Player();

            scenes.TitleScene();

            player.SetPlayerName();

            scenes.JobSelectScene();

            player.SetPlayerJobID(scenes.PickedJobID);

            player.SetPlayerStatus();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", player.Name, player.Str, player.Tec, player.Vit, player.Wis, player.Luc);

            Console.ReadLine();
            Console.Clear();
        }
    }
}
