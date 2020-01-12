using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe.Extensions
{
    public static class ByteExtensions
    {
        public static Button GetButton(this byte currByte, IEnumerable<Button> buttons)
        {
            return buttons.Single(b => byte.Parse(b.Name.Last().ToString()) == currByte);
        }
    }
}
