using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.BusinessLayer.Repository.Interaces
{
    public interface ISocketConnection
    {
        Task SendAsync(byte buttonNum);
        Task SendAsync(Button clickedButton);
        Task SendAsync((int, int) movePoint);
        void SetEnemyMoveAction(Action<byte> action);
    }
}
