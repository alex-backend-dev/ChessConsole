namespace ChessConsole
{
    public abstract class ChessFigure
    {
        private string _figureColor;

        public int HorizontalDescription { get; set; }

        public int VerticalDescription { get; set; }

        protected ChessFigure(string _figureColor, int HorizontalDescription, int VerticalDescription )
        {
            this._figureColor = _figureColor;
            this.HorizontalDescription = HorizontalDescription; 
            this.VerticalDescription = VerticalDescription;
        }
        public abstract void Move(int x, int y);
    }
}
