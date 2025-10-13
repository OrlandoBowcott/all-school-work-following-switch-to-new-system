public class Board
{
    private int[,] BoardArr;
    private int[,] PlayersArr;

    public Board()
    {
        BoardArr = new int[,]
        {
            { 0, 0, 1, 2, 3, 4, 5, 6, 7 },
            { 0, 5, 4, 3, 1, 2, 3, 4, 5 },
            { 1, 6, 6, 6, 6, 6, 6, 6, 6 },
            { 2, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 3, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 4, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 5, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 6, 6, 6, 6, 6, 6, 6, 6, 6 },
            { 7, 5, 4, 3, 2, 1, 3, 4, 5 }
        };
        PlayersArr = new int[,]
        {
            {1,1,1,1,1,1,1,1 },
            {1,1,1,1,1,1,1,1 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {2,2,2,2,2,2,2,2 },
            {2,2,2,2,2,2,2,2 }
        }
    }
    public int GetPositionUnit(int X, int Y)
    {
        int ThisPosition = BoardArr[X, Y];
        return ThisPosition;
    }
    public void SetPosition(int X, int Y, int PieceID)
    {
        BoardArr[X, Y] = PieceID;
    }
    public void MovePiece(int ChosenX, int ChosenY)
    {
        int SelectedPiece = GetPositionUnit(ChosenX, ChosenY);
        switch (SelectedPiece)
        {
            case 1: // King
                    // Implement king movement logic
                break;
            case 2: // Queen
                    // Implement queen movement logic
                break;
            case 3: // Bishop
                    // Implement bishop movement logic
                break;
            case 4: // Knight
                    // Implement knight movement logic
                break;
            case 5: // Rook
                    // Implement rook movement logic
                break;
            case 6: // Pawn
                    // Implement pawn movement logic
                break;
            default:
                // No piece selected or invalid piece
                break;
        }
    }
    public string[] GetMovementOptions(int ChosenX, int ChosenY)
    {
        if (ChosenX < 1 || ChosenX > 8 || ChosenY < 1 || ChosenY > 8)
        {
            return new string[] { "Invalid coordinates" };
        }

        int SelectedPiece = GetPositionUnit(ChosenX, ChosenY);

        switch (SelectedPiece)
        {
            case 1:
                bool[] ValidMoves = new bool[8];
                if ()

                break;
            case 2: // Queen
                    // Implement queen movement logic
                break;
            case 3: // Bishop
                    // Implement bishop movement logic
                break;
            case 4: // Knight
                    // Implement knight movement logic
                break;
            case 5: // Rook
                    // Implement rook movement logic
                break;
            case 6: // Pawn
                    // Implement pawn movement logic
                break;
            default:
                // No piece selected or invalid piece
                break;
        }
    }

    /*
     Documentation:
    pieces
     1 = king
     2 = queen
     3 = bishop
     4 = knight
     5 = rook
     6 = pawn

    movement options:
    king = 1 up 2 up right 3 right 4 down right 5 down 6 down left 7 left 8 up left no distance modifier
    queen = 1 up 2 up right 3 right 4 down right 5 down 6 down left 7 left 8 up left distance modifier 
    bishop = 2 up right 4 down right 6 down left 8 up left distance modifier
    knight = 1 up up right 2 right right up 3 right right down 4 down down right 5 down down left 6 left left down 7 left left up 8 up up left no distance modifier
    rook = 1 up 3 right 5 down 7 left distance modifier
    pawn = 1 up 2 up up first move only 3 up right attack 4 up left attack no distance modifier
    */

}