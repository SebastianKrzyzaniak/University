using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.Popup;
using TicTacToe.Static;

namespace TicTacToe.BusinessLayer.Repository
{
    public class GameConnection : IGameConnection
    {
        public GameConnection(StartPopup startPopup)
        {
            _startPopup = startPopup;
        }

        private TcpListener _tcpListener;
        private TcpClient _tcpClient;
        private Socket _socket;
        //private NetworkStream _networkStream;
        private readonly StartPopup _startPopup;

        public async Task ExpectConnectionAsync()
        {
            try
            {
                await ExecuteTask(() =>
                  {
                      _tcpListener = new TcpListener(DataStatic.MyIP, DataStatic.Port);

                      _tcpListener.Start();

                      _tcpClient = _tcpListener.AcceptTcpClient();

                      _socket = DataStatic.Socket = _tcpClient.Client;

                      //_networkStream = _tcpClient.GetStream();
                  });
            }
            catch (Exception ex)
            {
                Program.DIContainer.Resolve<MessageForm>().ShowMessage("Cannot find game for you");
                throw;
            }
        }

        public async Task JoinConnectionAsync()
        {
            try
            {
                await ExecuteTask(() =>
                   {
                       _tcpClient = new TcpClient(DataStatic.OponentIP.ToString(), DataStatic.Port);

                       _socket = DataStatic.Socket = _tcpClient.Client;

                       //NetworkStream networkStream = this._tcpClient.GetStream();
                   });
            }
            catch (SocketException sexc)
            {
                string msg = "No connection can be established";

                if (sexc.SocketErrorCode == SocketError.NetworkUnreachable) msg = "IP Address is incorrect!";
                if (sexc.SocketErrorCode == SocketError.ConnectionRefused) msg = "Connection refused!";

                Program.DIContainer.Resolve<MessageForm>().ShowMessage(msg);
                throw;
            }
            catch (Exception ex)
            {
                 Program.DIContainer.Resolve<MessageForm>().ShowMessage("No connection can be established");
                throw;
            }
        }

        private async Task ExecuteTask(Action action)
        {
            var popup = Program.DIContainer.Resolve<WaitingForConnection>();

            try
            {
                DataStatic.FreezeButtons(_startPopup);
                popup.Show();

                await Task.Run(action);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                popup.Close();
                DataStatic.UnfreezeButtons(_startPopup);
            }
        }
    }
}
