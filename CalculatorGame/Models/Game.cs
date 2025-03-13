using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGame.Models
{
    internal class Game
    {
        public DateTime Date {get; set;}
        public int Score { get; set; }
        public GameType Type { get; set; }
        public DifficultyLvl GameDifficulty { get; set; }
        public Stopwatch? GameTime { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    internal enum DifficultyLvl
    {
        Easy,
        Medium,
        Hard
    }
}
