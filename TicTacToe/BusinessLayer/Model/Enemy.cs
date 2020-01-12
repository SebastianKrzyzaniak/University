using System.Net;

namespace TicTacToe.BusinessLayer.Model
{
    public class Enemy : Player
    {
        public IPAddress IP { get; set; }
    }
}
