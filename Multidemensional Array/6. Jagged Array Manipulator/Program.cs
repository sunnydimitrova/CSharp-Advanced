using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var jagetArr = new double[n][];
            for (int row = 0; row < n; row++)
            {
                jagetArr[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();                
            }
            for (int row = 0; row < n - 1; row++)
            {
                if (jagetArr[row].Length == jagetArr[row + 1].Length)
                {
                    for (int col = 0; col < jagetArr[row].Length; col++)
                    {
                        jagetArr[row][col] *= 2;
                        jagetArr[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagetArr[row].Length; col++)
                    {
                        jagetArr[row][col] /= 2;
                    }
                    for (int col = 0; col < jagetArr[row + 1].Length; col++)
                    {
                        jagetArr[row + 1][col] /= 2;
                    }
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var splitedInput = input.Split();
                var command = splitedInput[0];
                var row = int.Parse(splitedInput[1]);
                var col = int.Parse(splitedInput[2]);
                var value = int.Parse(splitedInput[3]);
                if (command == "Add")
                {
                    if (row < n && row >= 0 && col < jagetArr[row].Length && col >= 0)
                    {
                        jagetArr[row][col] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    if (row < n && row >= 0 && col < jagetArr[row].Length && col >= 0)
                    {
                        jagetArr[row][col] -= value;
                    }
                }
            }
            foreach  (double[] row in jagetArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
