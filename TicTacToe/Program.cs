using System;
using System.Windows.Forms;
using TicTacToe.Bootstraper;
using TicTacToe.Popup;

namespace TicTacToe
{
    static class Program
    {
        public static DIContainer DIContainer { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DIContainer = new DIContainer();
            Application.Run(DIContainer.Resolve<StartPopup>());
        }
    }
}
