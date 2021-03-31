using System;

namespace _5
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
                    arr[i, j] = i % 2 == 0 ? 1 : 0;       // ete i=0 index@ hamarumenq 0-akan tox
                }                                         // arajin tox hamareluc, zut ternar Paymani mej arjeqneri texern kpoxven
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
