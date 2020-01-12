using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Model;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.BusinessLayer.Service.GameService.Interfaces;
using TicTacToe.Extensions;
using TicTacToe.Mapping.Interfaces;
using TicTacToe.Popup;
using TicTacToe.Static;

namespace TicTacToe.BusinessLayer.Service.GameService
{
    public class TurnLogic : ITurnLogic
    {
        private readonly string _imagesContainerPath;
        private readonly MainBackground _mainBackground;
        private readonly IJudge _judge;
        private readonly ISocketConnection _socketConnection;
        private readonly IControlsMapping _controlsMappings;
        private readonly IControlsRepository _controlsRepository;
        private List<Button> ClickedButtons = new List<Button>();

        public TurnLogic(MainBackground mainBackground, IJudge judge, ISocketConnection socketConnection, IControlsMapping controlsMappins, IControlsRepository controlsRepository)
        {
            _mainBackground = mainBackground;
            _judge = judge;
            _socketConnection = socketConnection;
            _controlsMappings = controlsMappins;
            _controlsRepository = controlsRepository;
            
            _socketConnection.SetEnemyMoveAction(EnemyMove);
            _judge.GameOver = GameOver;
            _imagesContainerPath = (Directory.GetCurrentDirectory().GetDirectoryName(2) + @"\ImagesContainer\");
        }

        private void EnemyMove(byte msg)
        {
            var mainboardForm = Program.DIContainer.Resolve<MainBackground>();

            ExecuteTurnAsync(_controlsMappings.ByteToButton(msg), DataStatic.Enemy, mainboardForm);

            SetButtonAvailability(mainboardForm, true);
        }

        public async void ExecuteTurnAsync(MainBackground boardForm, Button selectedButton, Player currPlayer)
        {
            SetButtonAvailability(boardForm, false);

            await ExecuteTurnAsync(selectedButton, currPlayer, boardForm);

            //SetButtonAvailability(boardForm, true); //todo odkomentowac???
        }

        private async Task ExecuteTurnAsync(Button selectedButton, Player currPlayer, MainBackground boardForm)
        {
            var opposedPlayer = currPlayer == DataStatic.Me ? DataStatic.Enemy : DataStatic.Me;

            boardForm.SetTurnMsg(opposedPlayer);

            SetControlsStatus(selectedButton, currPlayer);

            if (currPlayer == DataStatic.Me)
            {
                await _socketConnection.SendAsync(selectedButton); 
            }

            _judge.Move(currPlayer, selectedButton);
        }

        private void SetControlsStatus(Button button, Player currPlayer)
        {
            var playerSignImage = Image.FromFile(_imagesContainerPath.GetImagePath(currPlayer));

            button.BackgroundImage = playerSignImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.Enabled = false;
            ClickedButtons.Add(button);
        }

        private void SetButtonAvailability(MainBackground form, bool value)
        {
            foreach (var control in form.Controls)
            {
                if (control is Control)
                {
                    if (!form.ProtectedControls.Any(c => c == control) && !ClickedButtons.Any(b => b == control))
                    {
                        ((Control)control).Enabled = value;
                    }
                }

                form.Controls["gameBoard"].Focus();
            }
        }

        private void GameOver(GameResult gameResult, Player player)
        {
            var msg = String.Empty;

            if (gameResult == GameResult.Draw)
            {
                msg = "It is Draw...";
            }
            else
            {
                bool imWinner = DataStatic.Me == player;
                msg = imWinner
                  ? "You're the Winner!"
                  : "You Lost...";

                player.Score++;
            }

            _mainBackground.UpdateScore(DataStatic.Me.Score, DataStatic.Enemy.Score);

            Program.DIContainer.Resolve<MessageForm>().ShowMessage(msg);

            ClearBoard();
        }

        private void ClearBoard()
        {
            _judge.ClearBoard();
            ClickedButtons.Clear();

            foreach (var button in _controlsRepository.GetGameButtons(_mainBackground))
            {
                button.BackgroundImage = null;
            }
        }
    }
}
