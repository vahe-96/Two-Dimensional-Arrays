using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of two dimensional square array");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (i + j) % 2 == 0 ? 1 : 0;       // naxord xndri meknabanutyan pes 
                }
            }

            Console.WriteLine("Here is your array");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
