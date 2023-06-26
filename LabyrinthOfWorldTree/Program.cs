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
            Pub pub = new Pub();

            scenes.TitleScene();

            player.SetPlayerName();

            scenes.JobSelectScene();

            player.SetPlayerJobID(scenes.SelectedJobID);

            player.SetPlayerStatus();

            pub.SelectQuest();

            if (pub.SelectedQuestID != -1)
            {
                player.AcceptQuest(pub.QuestBoard[pub.SelectedQuestID]);
            }

            // Console.SetCursorPosition(0, 32);
            // Console.WriteLine(player.QuestList[0].QuestName);



            Console.ReadLine();
            Console.Clear();
        }
    }
}
