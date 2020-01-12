using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe.BusinessLayer.Repository.Interaces
{
    public interface IControlsRepository
    {
        List<Button> GetGameButtons(Form form);
    }
}
