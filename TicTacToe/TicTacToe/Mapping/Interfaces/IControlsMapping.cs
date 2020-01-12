using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe.Mapping.Interfaces
{
    public interface IControlsMapping
    {
        Dictionary<Button, (int vertical, int horizontal)> GameButtonToPointMapping { get; }

        byte ButtonToByte(Button button);

        Button ByteToButton(byte buttonNum);
    }
}
