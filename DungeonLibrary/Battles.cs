using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Battles
    {
        public static string GetBattle()
        {
            //Declare & Intialize battle array
            string[] battle =
            {
                "Battle of the Morannon.",
                "Battle of the Black Gate.",
                "Battle for Middle-earth.",
                "Battle Of Helms Deep.",
                "Battle For Minas Tirith.",
                "Battle of the Pelennor Fields.",
                "Battle of the Hornburg.",
                "Battle of Bywater."
            };

            //Declare random
            Random random = new Random();
            //Declare & Intialize index from a random number up to array length
            int index = random.Next(battle.Length);
            //Declare & Intialize battles getting the battle from the random index
            string battles = "You Have A New Battle...\n\n" + battle[index] + "\n";
            //Return battles
            return battles;
        }//end GetBattle
    }//end Class Battles
}//end NameSpace
