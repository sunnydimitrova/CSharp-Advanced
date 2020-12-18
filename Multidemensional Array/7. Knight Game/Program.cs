using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var chessBoard = new char[size, size];
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = input[col];
                }
            }
            var killerRow = 0;
            var killerCol = 0;
            var knightCounter = 0;

            while (true)
            {
                var maxAttack = 0;
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentKnightAttack = 0;
                        if (chessBoard[row, col] == 'K')
                        {
                            if (Inside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentKnightAttack++;
                            }
                            if (Inside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentKnightAttack++;
                            }
                        }
                        if (currentKnightAttack > maxAttack)
                        {
                            maxAttack = currentKnightAttack;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                    
                }
                if (maxAttack > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightCounter++;
                }
                else
                {
                    Console.WriteLine(knightCounter);
                    break;
                }
            }
        }

        private static bool Inside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
