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
            Console.Title = "-==== Battle Of The Ring ====-";
            Console.ForegroundColor = ConsoleColor.Yellow;
            string GameTitle = "****[BATTLE OF THE RING]****";
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
        }//end GameStart()
    }//end Class GameEntry
}//end NameSpace