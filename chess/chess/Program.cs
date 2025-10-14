

/*
 Documentation:
 1 = king
 2 = queen
 3 = bishop
 4 = knight
 5 = rook
 6 = pawn
*/

namespace chess
{
    class Program
    {
        static void DisplayBoard(Board chessBoard)
        {
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("   ");
                    }
                    else if (i == 0)
                    {
                        if (j == 9)
                        {
                            Console.Write(chessBoard.GetPositionUnit(i, j) + "\n");
                        }
                        else
                        {
                            Console.Write(chessBoard.GetPositionUnit(i, j) + "  ");
                        }

                    }
                    else if (j == 0)
                    {
                        Console.Write(chessBoard.GetPositionUnit(i, j) + " ");
                    }
                    else if (chessBoard.GetPositionUnit(i, j) == 1)
                    {
                        Console.Write("K ");
                    }
                    else if (chessBoard.GetPositionUnit(i, j) == 2)
                    {
                        Console.Write("Q ");
                    }
                    else if (chessBoard.GetPositionUnit(i, j) == 3)
                    {
                        Console.Write("B ");
                    }
                    else if (chessBoard.GetPositionUnit(i, j) == 4)
                    {
                        Console.Write("N ");
                    }
                    else if (chessBoard.GetPositionUnit(i, j) == 5)
                    {
                        Console.Write("R ");
                    }
                    else if (chessBoard.GetPositionUnit(i, j) == 6)
                    {
                        Console.Write("P ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Board chessBoard = new Board();
            
            DisplayBoard(chessBoard);
            string[] results = chessBoard.GetMovementOptions(4, 1, 1);
            for (int i = 1; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }


        }
    }
}
