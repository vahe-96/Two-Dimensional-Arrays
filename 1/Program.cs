using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5] { { 1, 5, 54, 8, 7 }, { 0, 5, 85, 36, 1 }, { 5, 85, 47, 69, 4 },
                                           { 41, 0, 12, 36, 5 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
