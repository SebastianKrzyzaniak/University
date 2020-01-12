using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Repository.Interaces;

namespace TicTacToe.BusinessLayer.Repository
{
    public class ControlsRepository : IControlsRepository
    {
        public List<Button> GetGameButtons(Form form)
        {
            var gameButtons = new List<Button>();

            foreach (var control in form.Controls)
            {
                if (control is Button && ((Control)control).Name.StartsWith("gameButton"))
                {
                    gameButtons.Add((Button)control);
                }
            }

            return gameButtons;
        }
    }
}
