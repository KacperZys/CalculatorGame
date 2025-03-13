using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using CalculatorGame.Models;

namespace CalculatorGame
{
    internal static class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
        //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        internal static int[] GetDivisionNumbers(Difficulty difLvl)
        {
            (int firstNumber, int secondNumber) = difLvl.GetRange();
            secondNumber *= 10;

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                (firstNumber, secondNumber) = difLvl.GetRange();
                secondNumber *= 10;
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void AddToHistory(int gameScore, GameType gameType, DifficultyLvl difLvl, Stopwatch stopwatch)
        {
            games.Add(new Game { Date = DateTime.Now, Score = gameScore, Type = gameType, GameDifficulty = difLvl, GameTime = stopwatch});
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------");
            foreach (var game in games)
            {
                string elapsedTime = String.Format("{0:D2}:{1:D2}:{2:D2}",
                game.GameTime.Elapsed.Hours, game.GameTime.Elapsed.Minutes, game.GameTime.Elapsed.Seconds);

                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts - difficulty: {game.GameDifficulty} - Time: {elapsedTime}");
            }
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }

        internal static string ValidateResult(string? result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static int GetDifficultyLvl()
        {
            Console.WriteLine("Select difficulty level: ");
            Console.WriteLine("1. easy");
            Console.WriteLine("2. medium");
            Console.WriteLine("3. hard\n");

            return int.Parse(Helpers.ValidateResult(Console.ReadLine()));
        }

        internal static Difficulty SetDifficultyLevel(int lvl)
        {
            DifficultyLvl level = lvl switch
            {
                1 => DifficultyLvl.Easy,
                2 => DifficultyLvl.Medium,
                3 => DifficultyLvl.Hard,
                _ => DifficultyLvl.Easy
            };

            return new Difficulty(level);
        }

        internal static Stopwatch StartTimer()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            return stopwatch;
        }

        internal static void StopTimer(Stopwatch stopwatch)
        {
            stopwatch.Stop();
        }

        internal static void DisplayTimeElapsed(Stopwatch stopwatch)
        {
            string elapsedTime = String.Format("{0:D2}:{1:D2}:{2:D2}",
                stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);

            Console.WriteLine($"Elapsed time: {elapsedTime}");
        }
    }
}
