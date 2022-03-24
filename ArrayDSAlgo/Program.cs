using System;

namespace ArrayDSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Score = new int[] { 1, 2, 3, 4, };
            int totalScore = 0;

            int[] Score2 = { 1, 2, 3, 4, };
            int totalScore2 = 0;

            for (int i = 0; i <= Score.Length - 1; i++)
            {
                if (Score[i] % 2 == 0 & Score[i] != 8)
                {
                    Score[i] = 1;
                    totalScore2 += Score[i];
                }

                totalScore += Score[i];
            }
            Console.WriteLine("Total Score : {0}", totalScore);

            foreach (var item in Score2)
            {
                if (item % 2 == 0 & item != 8)
                {
                    totalScore2 += item;
                }

            }
            Console.WriteLine("Total Score : {0}", totalScore2);

            Console.WriteLine("Specify size of Array to store score");
            int size = int.Parse(Console.ReadLine());
            CalTotalScores(size);
        }

        public static void CalTotalScores(int size)
        {
            var totalSc = 0;
            int[] Score = new int[size];

            for (int i = 0; i <= size - 1; i++)
            {
                Console.WriteLine("Enter score {0}", i);
                Score[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= size - 1; i++)
            {
                if (Score[i] % 2 == 0 & Score[i] != 8)
                {
                    Score[i] = 1;
                    //Score[i] += Score[i];
                    totalSc += Score[i];
                }
                else if (Score[i] % 2 == 0 & Score[i] == 8)
                {
                    Score[i] = 1 + 5;
                    //Score[i] += Score[i];
                    totalSc += Score[i];
                }
                else
                {
                    Score[i] = 3;
                    //Score[i] += Score[i];
                    totalSc += Score[i];
                }

            }

            Console.WriteLine("Total Score base on input critria: {0}", totalSc);

        }
    }
}
