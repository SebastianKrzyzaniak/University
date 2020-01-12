using System;
using System.Windows.Forms;

namespace TicTacToe.Popup
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message)
        {
            btnMessage.Text = message;

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
