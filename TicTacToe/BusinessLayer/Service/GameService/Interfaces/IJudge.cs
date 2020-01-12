using System;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Model;

namespace TicTacToe.BusinessLayer.Service.GameService.Interfaces
{
    public interface IJudge
    {
        void Move(Player player, Button clickedButton);
        
        /// <summary>
        ///If bool is true => we have winner 
        ///IF bool is false => we have draw
        /// </summary>
        Action<GameResult, Player> GameOver { get; set; }
        void ClearBoard();
    }

    public enum GameResult
    {
        Draw,
        Winner
    }
}
