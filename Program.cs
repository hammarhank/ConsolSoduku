using System;

namespace ConsolSoduku
{
    internal class Program
    {
        class SudokuBoard
        {
            private int[,] board;

            public void GenerateBoard()
            {
                board = new int[9, 9];
                GenerateBoardFill(0, 0);
            }

            private bool GenerateBoardFill(int row, int col)
            {
                if (row == 9) // Brädet är färdigt
                {
                    return true;
                }
                if (col == 9) // Fortsätt till nästa rad
                {
                    return GenerateBoardFill(row + 1, 0);
                }
                // Prova alla möjliga värden på den aktuella cellen
                for (int val = 1; val <= 9; val++)
                {
                    if (IsMoveValid(row, col, val))
                    {
                        board[row, col] = val;
                        if (GenerateBoardFill(row, col + 1)) // Giltigt bräde hittat
                        {
                            return true;
                        }
                        board[row, col] = 0; // Återställ cellen
                    }
                }
                return false; // Ingen lösning hittad
            }

            private bool IsMoveValid(int row, int col, int val)
            {
                // Kontrollera rad och kolumn
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == val || board[i, col] == val)
                    {
                        return false;
                    }
                }
                // Kontrollera 3x3-rutan
                int boxRow = row - row % 3;
                int boxCol = col - col % 3;
                for (int i = boxRow; i < boxRow + 3; i++)
                {
                    for (int j = boxCol; j < boxCol + 3; j++)
                    {
                        if (board[i, j] == val)
                        {
                            return false;
                        }
                    }
                }
                return true; // Draget är giltigt
            }
            public void PrintBoard()
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(board[i, j] + " ");
                        if ((j + 1) % 3 == 0)
                        {
                            Console.Write("| ");
                            Thread.Sleep(500);
                        }
                    }
                    Console.WriteLine();
                    if ((i + 1) % 3 == 0)
                    {
                        Console.WriteLine("----------------------");
                        Thread.Sleep(500);
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            SudokuBoard board = new SudokuBoard();
            board.GenerateBoard();
            board.PrintBoard();
        }
    }
}