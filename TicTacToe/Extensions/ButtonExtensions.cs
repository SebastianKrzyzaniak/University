using System.Linq;
using System.Windows.Forms;

namespace TicTacToe.Extensions
{
    public static class ButtonExtensions
    {
        public static byte ToByte(this Button currButton)
        {
            return byte.Parse(currButton.Name.Last().ToString());
        }
    }
}
