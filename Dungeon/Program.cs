using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DungeonLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName;
            int score = 0;
            bool characterMenu = true;
            PlayerCharacter playerCharacter = PlayerCharacter.Human;

            Console.SetWindowSize(110, 45);

            GameEntry.GameStart();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(GameBanner.GetGameBanner() + "\n\n");            

            //Players Name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter your characters name: ");
            characterName = Console.ReadLine().ToUpper();
            Console.Clear();

            //Select Character
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                PlayerMenu.PlayerSelectMenu();
                ConsoleKey characterChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (characterChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        playerCharacter = PlayerCharacter.Human;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        playerCharacter = PlayerCharacter.Elf;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        playerCharacter = PlayerCharacter.Dwarf;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        playerCharacter = PlayerCharacter.Goblin;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        playerCharacter = PlayerCharacter.Wizard;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        playerCharacter = PlayerCharacter.Hobbit;
                        characterMenu = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{characterChoice} was not a valid option.  Please choose again.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
            } while (characterMenu);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome, {characterName} the {playerCharacter}!\n\nYour battle now begins...");
            if (playerCharacter.ToString() == "Hobbit")
            {
                Console.WriteLine(Hobbit.GetHobbit() + "\n\n");
            }
            if (playerCharacter.ToString() == "Wizard")
            {
                Console.WriteLine(Wizard.GetWizard() + "\n\n");
            }
            if (playerCharacter.ToString() == "Goblin")
            {
                Console.WriteLine(Goblin.GetGoblin() + "\n\n");
            }
            if (playerCharacter.ToString() == "Dwarf")
            {
                Console.WriteLine(Dwarf.GetDwarf() + "\n\n");
            }
            if (playerCharacter.ToString() == "Elf")
            {
                Console.WriteLine(Elf.GetElf() + "\n\n");
            }
            if (playerCharacter.ToString() == "Human")
            {
                Console.WriteLine(Human.GetHuman() + "\n\n");
            }
            System.Threading.Thread.Sleep(4500);

            Console.Clear();

            //Weapons
            Weapon sword = new Weapon(2, 8, "Broad Sword", 8, true);
            Weapon axe = new Weapon(3, 6, "Battle Axe", 10, true);
            Weapon mace = new Weapon(1, 10, "Bludgeoning Mace", 15, false);
            Weapon bowarrow = new Weapon(1, 7, "Bow and Arrow", 11, true);

            //Choose Weapon
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("As you forge forward into the night, something catch's your attention ahead...\n");
            System.Threading.Thread.Sleep(4000);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Mountain.GetMountain() + "\n\n\n");

            bool chosen = false;
            Weapon userWeapon = new Weapon();

            do
            {
                WeaponMenu.Weapons();
                ConsoleKey weaponChoice = Console.ReadKey(true).Key;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                switch (weaponChoice)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("It is heavy, but you're confident as you head further into battle with your Broadsword...\n\n");
                        userWeapon = sword;
                        chosen = true;
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("After lifting the Battle Axe, a surge of courage flows through you as you turn towards the dark lifeless night...\n\n");
                        userWeapon = axe;
                        chosen = true;
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("Snatching up the bludgeoning Mace, you make your way deeper into the foggy dark night...\n\n");
                        userWeapon = mace;
                        chosen = true;
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("With your bow around your shoulder and your arrows hanging from your back, you move forward in the moonlight...\n\n");
                        userWeapon = mace;
                        chosen = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid weapon choice.\n");
                        Console.ResetColor();
                        break;
                }
            } while (!chosen);

            //Player
            Player player = new Player(characterName, 70, 2, 50, 50, playerCharacter, userWeapon);

            System.Threading.Thread.Sleep(7000);
            Console.Clear();

            bool exit = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Battles.GetBattle());
                Console.ResetColor();
                Console.WriteLine("Press any key to continue.\n");
                Console.ReadKey();
                Console.Clear();

                //Monsters
                Orcs orc = new Orcs();
                Dunlendings dunlendings = new Dunlendings();
                Troll troll = new Troll();
                Urukhai urukai = new Urukhai();

                Monster[] monsters = { orc, dunlendings, troll, urukai };

                Random random = new Random();
                int randomMonster = random.Next(monsters.Length);
                Monster monster = monsters[randomMonster];

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A ENEMY APPEARS! : " + monster.Name + "\n");

                bool reload = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("### Please Choose an Action ###\n\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        "[A] Atack\n" +
                        "[R] Run Away\n" +
                        "[P] Player Info\n" +
                        "[I] Info Enemy\n" +
                        "[X] Exit \n\n" +
                        "Enemies Defeated: {0}\n\n",
                        score);

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                        case ConsoleKey.Enter:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("### Attack ###\n");
                            Console.ResetColor();
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You defeated {0}!!\n\n", monster.Name);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("The Princess Is Saved...");
                                Console.WriteLine(Princess.GetPrincess());
                                Console.ResetColor();
                                
                                //Found beeps on internet console beep sounds
                                Console.Beep(987, 53);
                                Thread.Sleep(53);
                                Console.Beep(987, 53);
                                Thread.Sleep(53);
                                Console.Beep(987, 53);
                                Thread.Sleep(53);
                                Console.Beep(987, 428);
                                Console.Beep(784, 428);
                                Console.Beep(880, 428);
                                Console.Beep(987, 107);
                                Thread.Sleep(214);
                                Console.Beep(880, 107);
                                Console.Beep(987, 857);

                                reload = true;
                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("### Run Away ###\n");
                            Console.ResetColor();
                            Console.WriteLine($"{monster.Name} attacks you as you run away!\n");
                            System.Threading.Thread.Sleep(500);
                            Combat.DoAttack(monster, player);
                            System.Threading.Thread.Sleep(2500);
                            reload = true;
                            break;
                        case ConsoleKey.P:
                        case ConsoleKey.H:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("### Player Information ###\n");
                            Console.ResetColor();
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.I:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("### Enemy Information ###\n");
                            Console.ResetColor();
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.Q:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine($"TOTAL ENEMIES DEFATED: {score}\n");
                            GameEnd.GameOver();
                            Console.ResetColor();
                            exit = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Unrecognized selection.  Please try again.\n");
                            Console.ResetColor();
                            break;
                    }

                    //Player Life
                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOU HAVE DIED.\n");
                        Console.ResetColor();
                        exit = true;
                    }

                } while (!reload && !exit);
            } while (!exit);
        }//end Main
    }//end Class
}//end NameSpace