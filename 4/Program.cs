using System;

namespace _4
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
                    arr[i, j] = i == j ? 1 : 0;      // Ternar operacia, kam aranc dra cikli mej 0 veragrel bolorin, 
                }                                    // ciklic el durs arr[i,i]=1;

                // arr[i, n - 1 - i] = 1;       // ete ditarkvi myus ankyunagicn el;
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
