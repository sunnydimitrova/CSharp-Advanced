using System;
using System.Linq;

namespace Snake
{
    class Program
    {
        static int rowIndex = 0;
        static int colIndex = 0;
        static int food = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            ReadMatrixAndFindLocation(matrix);
            while (true)
            {
                if (food >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {food}");
                    matrix[rowIndex, colIndex] = 'S';
                    break;
                }
                var command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[rowIndex, colIndex] = '.';
                    rowIndex = rowIndex - 1;
                    if (rowIndex >= 0)
                    {
                        SnakeMove(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                else if (command == "down")
                {
                    matrix[rowIndex, colIndex] = '.';
                    rowIndex = rowIndex + 1;
                    if (rowIndex <= n - 1)
                    {
                        SnakeMove(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                else if (command == "left")
                {
                    matrix[rowIndex, colIndex] = '.';
                    colIndex = colIndex - 1;
                    if (colIndex >= 0)
                    {
                        SnakeMove(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                else if (command == "right")
                {
                    matrix[rowIndex, colIndex] = '.';
                    colIndex = colIndex + 1;
                    if (colIndex <= n - 1)
                    {
                        SnakeMove(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
            }
            PrintMatrix(matrix);
        }

        private static void ReadMatrixAndFindLocation(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'S')
                    {
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInsite(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void SnakeMove(char[,] matrix)
        {
            if (matrix[rowIndex, colIndex] == '*')
            {
                food++;
                matrix[rowIndex, colIndex] = '.';
            }
            else if (matrix[rowIndex, colIndex] == 'B')
            {
                matrix[rowIndex, colIndex] = '.';
                bool isB = false;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '.';
                            rowIndex = row;
                            colIndex = col;
                            isB = true;
                            break;
                        }
                    }
                    if (isB)
                    {
                        break;
                    }
                }
            }
            else
            {
                matrix[rowIndex, colIndex] = '.';
            }
        }
    }
}
