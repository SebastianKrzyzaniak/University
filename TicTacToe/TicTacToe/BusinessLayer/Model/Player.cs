namespace TicTacToe.BusinessLayer.Model
{
    public abstract class Player
    {
        public Sign Sign { get; set; }
        public int Port { get; set; }
        public int Score { get; set; }
    }

    public enum Sign
    {
        Empty,
        Cross,
        Circle
    }
}
