using System;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Model;
using TicTacToe.BusinessLayer.Service.GameService.Interfaces;
using TicTacToe.Mapping.Interfaces;

namespace TicTacToe.BusinessLayer.Service.GameService
{
    public class Judge : IJudge
    {
        private readonly IControlsMapping _controlsMapping;
        private Sign[,] GameBoard = new Sign[3, 3];

        public Action<GameResult, Player> GameOver { get; set; }     //Win; Draw

        public Judge(IControlsMapping controlsMapping)
        {
            _controlsMapping = controlsMapping;
        }

        public void Move(Player player, Button clickedButton)
        {
            var point = _controlsMapping.GameButtonToPointMapping[clickedButton];
            GameBoard[point.vertical, point.horizontal] = player.Sign;
            CheckBoard(player);
        }

        private void CheckBoard(Player player)
        {
            if (IsWinner()) GameOver?.Invoke(GameResult.Winner, player);
            else if (IsDraw()) GameOver?.Invoke(GameResult.Draw, null);
        }

        private bool IsWinner()
        {
            var diagonalResult = GameBoard[0, 0];

            for (int vertical = 0; vertical < GameBoard.GetLongLength(0); vertical++)
            {
                var horizontalResult = GameBoard[0, vertical];
                var verticalResult = GameBoard[vertical, 0];

                for (int horizontal = 0; horizontal < GameBoard.GetLongLength(1); horizontal++)
                {
                    if (horizontalResult != GameBoard[horizontal, vertical])
                    {
                        horizontalResult = Sign.Empty;
                    }

                    if (verticalResult != GameBoard[vertical, horizontal])
                    {
                        verticalResult = Sign.Empty;
                    }

                    if (vertical == horizontal)
                    {
                        if (diagonalResult != GameBoard[vertical, horizontal])
                        {
                            diagonalResult = Sign.Empty;
                        }
                    }
                }

                if (horizontalResult != Sign.Empty || verticalResult != Sign.Empty) return true;
            }

            if (diagonalResult != Sign.Empty) return true;

            return false;
        }

        private bool IsDraw()
        {
            foreach (var sign in GameBoard)
            {
                if (sign == Sign.Empty) return false;
            }

            return true;
        }

        public void ClearBoard()
        {
            GameBoard = new Sign[3,3];
        }
    }

}
