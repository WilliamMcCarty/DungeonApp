﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GameBanner
    {
        public static string GetGameBanner()
        {
            string gameBanner = @"                                             _______________________
   _______________________-------------------                       `\
 /:--__                                                              |
||< > |                                   ___________________________/
| \__/_________________-------------------                         |
|                                                                  |
 |                       BATTLE OF THE RING                         |
 |                                                                  |
 |       Three Rings for the Elven-kings under the sky,             |
  |        Seven for the Dwarf-lords in their halls of stone,        |
  |      Nine for Mortal Men doomed to die,                          |
  |        One for the Dark Lord on his dark throne                  |
  |      In the Land of Mordor where the Shadows lie.                 |
   |       One Ring to rule them all, One Ring to find them,          |
   |       One Ring to bring them all and in the darkness bind them   |
   |     In the Land of Mordor where the Shadows lie.                |
  |                                              ____________________|_
  |  ___________________-------------------------                      `\
  |/`--_                                                                 |
  ||[ ]||                                            ___________________/
   \===/___________________--------------------------";

            return gameBanner;
        }//end GetGameBanner()
    }//end Class GameBanner
}//end NameSpace