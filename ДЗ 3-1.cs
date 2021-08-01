using System;

namespace ДЗ_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j=0; j<mass.GetLength(1);j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{mass[i,j]}");
                    }

                }
                Console.WriteLine();

            }


        }
    }
}
