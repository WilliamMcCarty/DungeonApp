using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GameEntry
    {
        public static void GameStart()
        {
            Console.Title = "-==== Fast Food Of Doom ====-";
            Console.ForegroundColor = ConsoleColor.Yellow;
            string GameTitle = "****[FAST FOOD OF DOOM]****";
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(GameTitle);
                System.Threading.Thread.Sleep(150);
                GameTitle = " " + GameTitle;
                Console.Clear();
            }
            Console.Beep(1500, 500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(GameTitle);
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Avoid being attacked by the fast food as you work your way through the restaurant.  If you are confronted choose your weapon carefully based on the food that is about to attack you.\n");
        }
    }
}
