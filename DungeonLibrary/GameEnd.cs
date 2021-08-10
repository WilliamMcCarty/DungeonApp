using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GameEnd
    {
        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you for playing DUNGEON OF SECRETS!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("****GAME OVER****");
        }//end GameOver()
    }//end Class GameEnd
}//end NameSpace