using System;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.Mapping.Interfaces;
using TicTacToe.Static;

namespace TicTacToe.BusinessLayer.Repository
{
    public class SocketConnection : ISocketConnection
    {
        private readonly IControlsMapping _controlsMappings;
        private readonly Socket _socket;
        private Action<byte> _action;

        public SocketConnection(IControlsMapping controlsMappings)
        {
            _controlsMappings = controlsMappings;

            _socket = DataStatic.Socket;

            Receive();
        }

        private async Task Receive()
        {
            while (true)
            {
                var msg = new byte[1];

                await Task.Run(() =>
                {
                    _socket.Receive(msg);
                });

                _action?.Invoke(msg[0]); 
            }
        }

        public async Task SendAsync(byte buttonNum)
        {
            try
            {
                await Task.Run(() =>
                {
                    _socket.Send(new byte[1] { buttonNum });
                });
            }
            catch (Exception ex)
            {
                //todo
            }
        }

        public async Task SendAsync(Button clickedButton)
        {
            await SendAsync(_controlsMappings.ButtonToByte(clickedButton));
        }

        public async Task SendAsync((int, int) movePoint)
        {
           await SendAsync(_controlsMappings.GameButtonToPointMapping.First(kvp => 
            kvp.Value.vertical == movePoint.Item1 
            && kvp.Value.horizontal == movePoint.Item2)
            .Key);
        }

        public void SetEnemyMoveAction(Action<byte> action)
        {
            _action = action;
        }
    }
}
