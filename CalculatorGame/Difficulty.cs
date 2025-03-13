using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using CalculatorGame.Models;

namespace CalculatorGame
{
    class Difficulty
    {
        public DifficultyLvl Level { get; set; }
        public Difficulty (DifficultyLvl difficultyLvl)
        {
            Level = difficultyLvl;
        }

        public (int, int) GetRange()
        {
            Random random = new Random();
            int[] range = new int[2];

            switch (Level)
            {
                case DifficultyLvl.Easy:
                    range[0] = random.Next(1, 9);
                    range[1] = random.Next(1, 9);
                    break;
                case DifficultyLvl.Medium:
                    range[0] = random.Next(1, 50);
                    range[1] = random.Next(1, 50);
                    break;
                case DifficultyLvl.Hard:
                    range[0] = random.Next(1, 100);
                    range[1] = random.Next(1, 100);
                    break;
            }

            return (range[0], range[1]);
        }

        public (int, int) GetRangeForDivision()
        {
            Random random = new Random();
            int[] range = new int[2];

            switch (Level)
            {
                case DifficultyLvl.Easy:
                    range[0] = random.Next(1, 100);
                    range[1] = random.Next(1, 100);
                    break;
                case DifficultyLvl.Medium:
                    range[0] = random.Next(1, 500);
                    range[1] = random.Next(1, 500);
                    break;
                case DifficultyLvl.Hard:
                    range[0] = random.Next(1, 1000);
                    range[1] = random.Next(1, 1000);
                    break;
            }

            return (range[0], range[1]);
        }
    }
}
