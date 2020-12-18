using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            int[,] bestMatrix = new int[3, 3];
            int bestSum = 0;
            int bestRowIndex = 0;
            int bestColIndex = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }
            for (int row = 0; row < n[0] - 2; row++)
            {
                for (int col = 0; col < n[1] - 2; col++)
                {
                    int firstLine = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int secondLine = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int thirtLine = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    int currentSum = firstLine + secondLine + thirtLine;
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {bestSum}");
            for (int row = bestRowIndex; row < bestRowIndex + 3; row++)
            {
                for (int col = bestColIndex; col < bestColIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
