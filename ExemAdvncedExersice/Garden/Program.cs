using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            var matrix = new int[dimension[0], dimension[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                var cordinates = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var row = cordinates[0];
                var col = cordinates[1];
                if (IsInsite(matrix, row, col))
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            if (rows == row || cols == col)
                            {                               
                                matrix[rows, cols]++;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }
            PrintMatrix(matrix);

        }

        private static bool IsInsite(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void PrintMatrix(int[,] matrix)
        {
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
