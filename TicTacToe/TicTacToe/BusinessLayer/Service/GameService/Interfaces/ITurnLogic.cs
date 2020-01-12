using System.Windows.Forms;
using TicTacToe.BusinessLayer.Model;

namespace TicTacToe.BusinessLayer.Service.GameService.Interfaces
{
    public interface ITurnLogic
    {
        void ExecuteTurnAsync(MainBackground boardForm, Button selectedButton, Player currPlayer);
    }
}
