using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName;
            bool characterMenu = true;
            PlayerCharacter playerCharacter = PlayerCharacter.Manager;

            GameEntry.GameStart();
            Console.WriteLine("Enter your characters name: ");
            characterName = Console.ReadLine();
            Console.Clear();

            do
            {
                PlayerMenu.PlayerSelectMenu();
                ConsoleKey characterChoice = Console.ReadKey().Key;
                Console.Clear();
                
                switch (characterChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        playerCharacter = PlayerCharacter.Cook;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        playerCharacter = PlayerCharacter.Cleaner;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        playerCharacter = PlayerCharacter.Manager;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        playerCharacter = PlayerCharacter.Counter;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        playerCharacter = PlayerCharacter.Lobby;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        playerCharacter = PlayerCharacter.DriveThru;
                        characterMenu = false;
                        break;

                    default:
                        Console.WriteLine($"{characterChoice} was not a valid option.  Please choose again.");
                        break;

                }
            } while (characterMenu);

            Console.WriteLine($"Welcome, {characterName} the {playerCharacter}!\n\nYour journey now begins...");
            System.Threading.Thread.Sleep(2500);

            bool exit = false;

            do
            {                
                bool reload = false;
                do
                {
                    Menu.GameMenu();
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.B:

                            break;

                        case ConsoleKey.R:

                            break;

                        case ConsoleKey.P:

                            break;

                        case ConsoleKey.V:

                            break;

                        case ConsoleKey.Escape:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have choosen to exit the game...\n");
                            exit = true;
                            break;

                        default:
                            break;
                    }

                } while (!exit && !reload);

            } while (!exit);

            GameEnd.GameOver();
        }
    }
}