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

            Scenes scenes = new Scenes(); // MaxHp = 100, Hp = MaxHp
            
            
            Player player = new Player();
            Battle battle = new Battle();
            Town town = new Town();

            scenes.TitleScene();

            player.SetPlayerName();

            scenes.JobSelectScene();

            player.SetPlayerJobID(scenes.SelectedJobID);

            player.SetPlayerStatus();

            while (true)
            {
                if(player.Health == 0)
                {
                    break;
                }
                
                town.TownScene(player);
            }
        }
    }
}
