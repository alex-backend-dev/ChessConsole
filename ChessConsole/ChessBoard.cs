namespace ChessConsole
{
    public class ChessBoard
    {
        private int _boardSize;

        private int[,] board;

        public ChessBoard(int _boardSize)
        {
            this._boardSize = _boardSize;

            board = new int[_boardSize, _boardSize];
        }

        public void CheckBoard(ChessFigure chessFigure)
        {
            if (chessFigure.HorizontalDescription  > _boardSize || chessFigure.VerticalDescription > _boardSize
                || chessFigure.HorizontalDescription < _boardSize || chessFigure.VerticalDescription < _boardSize)
            {
                throw new Exception("Нельзя выходить за размерность доски!");
            }
        }
    }
}
