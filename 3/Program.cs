﻿using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"{j + 1}*{i + 1}={arr[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
