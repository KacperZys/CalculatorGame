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
    internal class GameEngine
    {
        //public DifficultyLvl difLvl;

        internal void DivisionGame(string message, Difficulty difLvl)
        {
            var score = 0;
            Stopwatch stopwatch = Helpers.StartTimer();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers(difLvl);
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Helpers.StopTimer(stopwatch);
            Helpers.DisplayTimeElapsed(stopwatch);
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Division, difLvl.Level, stopwatch);
        }

        internal void MultiplicationGame(string message, Difficulty difLvl)
        {
            var score = 0;
            Stopwatch stopwatch = Helpers.StartTimer();

            (int firstNumber, int secondNumber) = difLvl.GetRange();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                (firstNumber, secondNumber) = difLvl.GetRange();

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Helpers.StopTimer(stopwatch);
            Helpers.DisplayTimeElapsed(stopwatch);
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Multiplication, difLvl.Level, stopwatch);
        }

        internal void SubtractionGame(string message, Difficulty difLvl)
        {
            var score = 0;
            Stopwatch stopwatch = Helpers.StartTimer();

            (int firstNumber, int secondNumber) = difLvl.GetRange();


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                (firstNumber, secondNumber) = difLvl.GetRange();

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Helpers.StopTimer(stopwatch);
            Helpers.DisplayTimeElapsed(stopwatch);
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Subtraction, difLvl.Level, stopwatch);
        }

        internal void AdditionGame(string message, Difficulty difLvl)
        {
            var score = 0;
            Stopwatch stopwatch = Helpers.StartTimer();

            (int firstNumber, int secondNumber) = difLvl.GetRange();


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                (firstNumber, secondNumber) = difLvl.GetRange();

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Helpers.StopTimer(stopwatch);
            Helpers.DisplayTimeElapsed(stopwatch);
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Addition, difLvl.Level, stopwatch);
        }
        }
}
