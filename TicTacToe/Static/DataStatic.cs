using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Model;

namespace TicTacToe.Static
{
    public static class DataStatic
    {
        public static bool ImAttacker;
        public static Socket Socket;

        public static IPAddress MyIP;
        public static IPAddress OponentIP;
        public static int Port;

        public static Player Me = new Me();

        public static Player Enemy = new Enemy();

        public static void FreezeButtons(Form form)
        {
            foreach (var control in form.Controls)
            {
                ((Control)control).Enabled = false;
            }
        }

        public static void FreezeButtons(Form form, params Control[] withExceptionControls)
        {
            foreach (var control in form.Controls)
            {
                if (!withExceptionControls.Any(c => c == control))
                {
                    ((Control)control).Enabled = false; 
                }
            }
        }

        public static void UnfreezeButtons(Form form)
        {
            foreach (var control in form.Controls)
            {
                ((Control)control).Enabled = true;
            }
        }
    }
}