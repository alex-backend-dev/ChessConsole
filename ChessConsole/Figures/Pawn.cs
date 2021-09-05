namespace ChessConsole
{
    public class Pawn : ChessFigure
    {
        public Pawn(string _figureColor, int HorizontalDescription, int VerticalDescription) : base(_figureColor, HorizontalDescription, VerticalDescription)
        {      
        }
        public override void Move(int x, int y)
        {
            if (HorizontalDescription != x)
            {
                throw new Exception("Пешка не может так ходить!");
            }

            int correctY = VerticalDescription + 1;
            int correctionY = VerticalDescription + 2;

            if (correctY == y || correctionY == y)
            {
                VerticalDescription = y;
            }
        }
    }
}
