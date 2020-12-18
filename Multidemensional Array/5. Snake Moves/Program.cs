using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = matrixInfo[0];
            var c = matrixInfo[1];
            var matrix = new char[r, c];
            var snakeName = Console.ReadLine();
            var counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {                   
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeName[counter++];
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                        
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[counter++];
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
