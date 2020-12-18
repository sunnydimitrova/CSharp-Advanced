using System;
using System.Linq;

namespace Multidimensional_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sumFirst = 0;
            int sumSecond = 0;
            for (int row = 0; row < n; row++)
            {
                sumFirst += matrix[row, row];
                sumSecond += matrix[row, n - row - 1];
            }

            Console.WriteLine(Math.Abs(sumSecond - sumFirst));
        }
    }
}
