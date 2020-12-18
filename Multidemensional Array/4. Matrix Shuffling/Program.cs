using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = input[0];
            var c = input[1];
            var matrix = new int[r, c];
            var stringMatrix = new string[r, c];
            bool isStringMatrix = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input2 = Console.ReadLine();
                bool isTrue = int.TryParse(input2, out int result);
                if (isTrue)
                {
                    var cols = input2.Split().Select(int.Parse).ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = cols[col];
                    }
                }
                else
                {
                    isStringMatrix = true;
                    string[] cols = input2.Split().ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        stringMatrix[row, col] = cols[col];
                    }
                }
                
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var arr = command.Split();
                if (!arr.Contains("swap") || arr.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    var row1 = int.Parse(arr[1]);
                    var col1 = int.Parse(arr[2]);
                    var row2 = int.Parse(arr[3]);
                    var col2 = int.Parse(arr[4]);
                    if (row1 > r || col1 > c || row2 > r || col2 > c)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        if (isStringMatrix)
                        {
                            var currentItem = stringMatrix[row1, col1];
                            stringMatrix[row1, col1] = stringMatrix[row2, col2];
                            stringMatrix[row2, col2] = currentItem;
                            for (int row = 0; row < stringMatrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < stringMatrix.GetLength(1); col++)
                                {
                                    Console.Write(stringMatrix[row, col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            var currentItem = matrix[row1, col1];
                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = currentItem;
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
            }
        }        
    }
}
