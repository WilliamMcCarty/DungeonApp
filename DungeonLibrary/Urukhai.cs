using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Urukhai : Monster
    {
        public Urukhai()
        {
            MaxLife = 8;
            MaxDamage = 6;
            Name = "Uruk-hai";
            HitChance = 19;
            Block = 10;
            MinDamage = 1;
            Life = 8;
            Description = "A cross between Orcs and Goblins, they are very aggressive and a superior foot soldier....";
        }//end Urukhai()
    }//end Class Urukhai
}//end NameSpace