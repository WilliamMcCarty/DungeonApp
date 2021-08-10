using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dunlendings : Monster
    {
        public Dunlendings()
        {
            MaxLife = 8;
            MaxDamage = 5;
            Name = "Dunlending";
            HitChance = 17;
            Block = 11;
            MinDamage = 1;
            Life = 8;
            Description = "Primitive Wild Men do not trust them, they are hostile and vicious....";
        }//end Dunlendings()
    }//end Class Dinendings
}//end NameSpace