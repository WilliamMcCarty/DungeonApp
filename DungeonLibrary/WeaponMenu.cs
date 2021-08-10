using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class WeaponMenu
    {
        public static void Weapons()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("### Choose Your Weapon ###\n");
            Console.ResetColor();
            Console.WriteLine(
                "[S] Sword       - It still looks sharp, but might require both hands to wield.\n" +
                "[A] Axe         - This might do some damage, it will definitely require both hands to swing.\n" +
                "[M] Mace        - A bit lighter, this could be used with one hand. Something just feels right about it.\n" +
                "[B] Bow & Arrow - Good for distance, requires two hands and allows you to keep a distance from the enemy.\n");
        }//end Weapons()
    }//end Class WeaponMenu
}//end NameSpace
