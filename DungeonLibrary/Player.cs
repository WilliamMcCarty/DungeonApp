using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public PlayerCharacter PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player() { }

        public Player(string name, int hitChance, int block, int life, int maxLife, PlayerCharacter playerRace, Weapon equippedWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
        }

        public override string ToString()
        {
            return string.Format("+++++ {0} +++++\n\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon: {4}\n" +
                "Block: {5}\n" +
                "Race: {6}\n\n",
                Name, Life, MaxLife, CalcHitChance(), EquippedWeapon, Block, PlayerRace);
        }//end ToString

        public override int CalcDamage()
        {
            Random random = new Random();
            int damage = random.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }//end CalcDamage

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }//end CalcHitChance
    }//end Class Player
}//end NameSpace
