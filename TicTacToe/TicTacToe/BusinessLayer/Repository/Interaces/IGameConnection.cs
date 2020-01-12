using System.Threading.Tasks;

namespace TicTacToe.BusinessLayer.Repository.Interaces
{
    public interface IGameConnection
    {
        Task ExpectConnectionAsync();
        Task JoinConnectionAsync();
    }
}
