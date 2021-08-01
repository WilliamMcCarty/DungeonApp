using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Menu
    {
        public static void GameMenu()
        {
            string gameMenu = "Choose An Option From The Menu\n" +
                "B)attle\n" +
                "R)un\n" +
                "P)layer Stats\n" +
                "V)illian Stats\n";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(gameMenu);
        }
    }
}
