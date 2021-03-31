using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arr[i, j] = "" + (char)((int)'a' + j) + (char)((int)'8' - i);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
