using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Orcs : Monster
    {
        public Orcs()
        {
            MaxLife = 8;
            MaxDamage = 6;
            Name = "Orc";
            HitChance = 20;
            Block = 15;
            MinDamage = 1;
            Life = 8;
            Description = "The Orcs are a hostile species from the Pits of Utumno in Middle-Earth...";
        }//end Orcs()
    }//end Class Orcs
}//end NameSpace
