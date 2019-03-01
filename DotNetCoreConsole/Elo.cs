using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreConsole
{
    public static class GameResult
    {
        public const float WIN = 1F;
        public const float LOSE = 0F;
        public const float DRAW = 0.5F;
    }

    public class EloTableItem
    {
        public int bRmin { get; set; }
        public int bRmax { get; set; }

        public float stronger { get; set; }
        public float weaker { get; set; }
    }



    public static class EloTable
    {
        static EloTable()
        {
            Data = new EloTableItem[] {
                new EloTableItem{ bRmin = 0,   bRmax = 3,   stronger = 0.50F, weaker = 0.50F },
                new EloTableItem{ bRmin = 4,   bRmax = 10,  stronger = 0.51F, weaker = 0.49F },
                new EloTableItem{ bRmin = 11,  bRmax = 17,  stronger = 0.52F, weaker = 0.48F },
                new EloTableItem{ bRmin = 18,  bRmax = 25,  stronger = 0.53F, weaker = 0.47F },
                new EloTableItem{ bRmin = 26,  bRmax = 32,  stronger = 0.54F, weaker = 0.46F },
                new EloTableItem{ bRmin = 33,  bRmax = 39,  stronger = 0.55F, weaker = 0.45F },
                new EloTableItem{ bRmin = 40,  bRmax = 46,  stronger = 0.56F, weaker = 0.44F },
                new EloTableItem{ bRmin = 47,  bRmax = 53,  stronger = 0.57F, weaker = 0.43F },
                new EloTableItem{ bRmin = 54,  bRmax = 61,  stronger = 0.58F, weaker = 0.42F },
                new EloTableItem{ bRmin = 62,  bRmax = 68,  stronger = 0.59F, weaker = 0.41F },
                new EloTableItem{ bRmin = 69,  bRmax = 76,  stronger = 0.60F, weaker = 0.40F },
                new EloTableItem{ bRmin = 77,  bRmax = 83,  stronger = 0.61F, weaker = 0.39F },
                new EloTableItem{ bRmin = 84,  bRmax = 91,  stronger = 0.62F, weaker = 0.38F },
                new EloTableItem{ bRmin = 92,  bRmax = 98,  stronger = 0.63F, weaker = 0.37F },
                new EloTableItem{ bRmin = 99,  bRmax = 106, stronger = 0.64F, weaker = 0.36F },
                new EloTableItem{ bRmin = 107, bRmax = 113, stronger = 0.65F, weaker = 0.35F },
                new EloTableItem{ bRmin = 114, bRmax = 121, stronger = 0.66F, weaker = 0.34F },
                new EloTableItem{ bRmin = 122, bRmax = 129, stronger = 0.67F, weaker = 0.33F },
                new EloTableItem{ bRmin = 130, bRmax = 137, stronger = 0.68F, weaker = 0.32F },
                new EloTableItem{ bRmin = 138, bRmax = 145, stronger = 0.69F, weaker = 0.31F },
                new EloTableItem{ bRmin = 146, bRmax = 153, stronger = 0.70F, weaker = 0.30F },
                new EloTableItem{ bRmin = 154, bRmax = 162, stronger = 0.71F, weaker = 0.29F },
                new EloTableItem{ bRmin = 163, bRmax = 170, stronger = 0.72F, weaker = 0.28F },
                new EloTableItem{ bRmin = 171, bRmax = 179, stronger = 0.73F, weaker = 0.27F },
                new EloTableItem{ bRmin = 180, bRmax = 188, stronger = 0.74F, weaker = 0.26F },
                new EloTableItem{ bRmin = 189, bRmax = 197, stronger = 0.75F, weaker = 0.25F },
                new EloTableItem{ bRmin = 198, bRmax = 206, stronger = 0.76F, weaker = 0.24F },
                new EloTableItem{ bRmin = 207, bRmax = 215, stronger = 0.77F, weaker = 0.23F },
                new EloTableItem{ bRmin = 216, bRmax = 225, stronger = 0.78F, weaker = 0.22F },
                new EloTableItem{ bRmin = 226, bRmax = 235, stronger = 0.79F, weaker = 0.21F },
                new EloTableItem{ bRmin = 236, bRmax = 245, stronger = 0.80F, weaker = 0.20F },
                new EloTableItem{ bRmin = 246, bRmax = 256, stronger = 0.81F, weaker = 0.19F },
                new EloTableItem{ bRmin = 257, bRmax = 267, stronger = 0.82F, weaker = 0.18F },
                new EloTableItem{ bRmin = 268, bRmax = 278, stronger = 0.83F, weaker = 0.17F },
                new EloTableItem{ bRmin = 279, bRmax = 290, stronger = 0.84F, weaker = 0.16F },
                new EloTableItem{ bRmin = 291, bRmax = 302, stronger = 0.85F, weaker = 0.15F },
                new EloTableItem{ bRmin = 303, bRmax = 315, stronger = 0.86F, weaker = 0.14F },
                new EloTableItem{ bRmin = 316, bRmax = 328, stronger = 0.87F, weaker = 0.13F },
                new EloTableItem{ bRmin = 329, bRmax = 344, stronger = 0.88F, weaker = 0.12F },
                new EloTableItem{ bRmin = 345, bRmax = 357, stronger = 0.89F, weaker = 0.11F },
                new EloTableItem{ bRmin = 358, bRmax = 374, stronger = 0.90F, weaker = 0.10F },
                new EloTableItem{ bRmin = 375, bRmax = 391, stronger = 0.91F, weaker = 0.09F },
                new EloTableItem{ bRmin = 392, bRmax = 411, stronger = 0.92F, weaker = 0.08F },
                new EloTableItem{ bRmin = 412, bRmax = 432, stronger = 0.93F, weaker = 0.07F },
                new EloTableItem{ bRmin = 433, bRmax = 456, stronger = 0.94F, weaker = 0.06F },
                new EloTableItem{ bRmin = 457, bRmax = 484, stronger = 0.95F, weaker = 0.05F },
                new EloTableItem{ bRmin = 485, bRmax = 517, stronger = 0.96F, weaker = 0.04F },
                new EloTableItem{ bRmin = 518, bRmax = 559, stronger = 0.97F, weaker = 0.03F },
                new EloTableItem{ bRmin = 560, bRmax = 619, stronger = 0.98F, weaker = 0.02F },
                new EloTableItem{ bRmin = 620, bRmax = 734, stronger = 0.99F, weaker = 0.01F },
                new EloTableItem{ bRmin = 735, bRmax = int.MaxValue, stronger = 1.0F, weaker = 0F }
        };
        }

        private static EloTableItem[] Data { get; set; }

        public static float GetExpectedResult(float dR, bool stronger)
        {
            foreach (var item in Data)
            {
                if (item.bRmin <= dR && item.bRmax >= dR)
                {
                    if (stronger)
                    {
                        return item.stronger;
                    }
                    return item.weaker;
                }
            }
            throw new ArgumentException($"Wrong argument dR = {dR}");
        }

    }

    public static class Elo
    {
        public static float GetNewEloForA(float aElo, float bElo, int playedGames, float gameResult)
        {
            //Rнов = Rст + K * (N — Nож)
            //S_{A} — фактически набранное игроком A количество очков 
            //(1 очко за победу, 0,5 — за ничью и 0 — за поражение);

            bool stronger = (aElo - bElo) > 0;
            float dR = Math.Abs(aElo - bElo);
            int K = GetK(aElo, playedGames);
            var expectedResult = EloTable.GetExpectedResult(dR, stronger);

            var newRating = aElo + K * (gameResult - expectedResult);

            return newRating;
        }

        private static int GetK(float rating, int playedGames)
        {
            const int MAX_RATING = 2400;
            const int HIGH = 10;
            const int MEDIUM = 15;
            const int LOW = 25;
            const int PLAYED_GAMES_THRESHOLD_VALUE = 20;


            if (rating >= MAX_RATING)
            {
                return HIGH;
            }

            if (rating < MAX_RATING && playedGames >= PLAYED_GAMES_THRESHOLD_VALUE)
            {
                return MEDIUM;
            }

            return LOW;
        }
    }
}
