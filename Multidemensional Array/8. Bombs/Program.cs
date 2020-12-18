using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            var cordinates = Console.ReadLine().Split();
            for (int i = 0; i < cordinates.Length; i++)
            {
                var currentCordinates = cordinates[i].Split(",").Select(int.Parse).ToArray();
                var rowCordinat = currentCordinates[0];
                var colCordinat = currentCordinates[1];
                var currentBombValue = matrix[rowCordinat, colCordinat];
                for (int row = rowCordinat - 1; row <= rowCordinat + 1; row++)
                {
                    for (int col = colCordinat - 1; col <= colCordinat + 1; col++)
                    {
                        if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
                        { 
                            if (matrix[row, col] <= 0 || currentBombValue < 0)
                            {
                                continue;
                            }
                            matrix[row, col] -= currentBombValue;
                        }
                    }
                }
            }
            var aliveSels = 0;
            var sumOfSels = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveSels++;
                    sumOfSels += item;
                }
            }            
            Console.WriteLine($"Alive cells: {aliveSels}");
            Console.WriteLine($"Sum: {sumOfSels}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
