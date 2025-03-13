using CalculatorGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGame
{
    internal class Menu
    {
        GameEngine gamesClass = new();
        

        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");

            Difficulty difLvl = Helpers.SetDifficultyLevel(Helpers.GetDifficultyLvl());
           
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
What game would you like to play today? Choose from the options below:
V - View Previos Games
A - Addition
S - Substraction
M - Multiplication
D - Division
C - Change Difficulty
Q - Quit the program
");
                Console.WriteLine("---------------------------------------");

                string? gameSelected = Console.ReadLine();

                while (string.IsNullOrEmpty(gameSelected))
                {
                    gameSelected = Console.ReadLine();
                }

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gamesClass.AdditionGame("Addition game", difLvl);
                        break;
                    case "s":
                        gamesClass.SubtractionGame("Substraction game", difLvl);
                        break;
                    case "m":
                        gamesClass.MultiplicationGame("Multiplication game", difLvl);
                        break;
                    case "d":
                        gamesClass.DivisionGame("Division game", difLvl);
                        break;
                    case "c":
                        difLvl = Helpers.SetDifficultyLevel(Helpers.GetDifficultyLvl());
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid output");
                        break;
                }
            } while (isGameOn);
        }
    }
}
