using System;

namespace _9._Miner
{
    class Program
    {
        static int[] positionS;
        static char[,] matrix;
        static int counterC;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            matrix = new char[n, n];
            counterC = 0;
            positionS = new int[2];
            var commands = Console.ReadLine().Split();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (input[col] == 'c')
                    {
                        counterC++;
                    }
                    if (input[col] == 's')
                    {
                        positionS[0] = row;
                        positionS[1] = col;
                    }
                    matrix[row, col] = input[col];
                }
            }
            foreach (var command in commands)
            {
                if (command == "left")
                {

                }
                else if (command == "right")
                {

                }
                else if (command == "up")
                {

                }
                else if (command == "down")
                {

                }
            }
        }
        
        static void Move(int row, int col)
        {
            if (IsInside(positionS[0] + row, positionS[1] + col))
            {

            }
        }
        static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col <= matrix.GetLength(1);
        }
    }
}
