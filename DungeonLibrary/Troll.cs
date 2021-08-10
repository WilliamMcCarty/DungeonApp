using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Troll : Monster
    {
        public Troll()
        {
            MaxLife = 8;
            MaxDamage = 7;
            Name = "Troll";
            HitChance = 18;
            Block = 13;
            MinDamage = 1;
            Life = 8;
            Description = "10 foot troll, a cunning one from Middle-Earth and is strong and vicious....";
        }//end Troll()
    }//end Class Troll
}//end NameSpace