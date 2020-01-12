using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Model;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.Popup.Validate.Interfaces;
using TicTacToe.Static;

namespace TicTacToe.Popup
{
    public partial class StartPopup : Form
    {
        private IValidateTextBoxData _validateTextBoxData;
        private IGameConnection _gameConnection;
        private IPAddress _myIpAddress;

        public StartPopup()
        {
            InitializeComponent();

            InitializeComponents();

            Initialize();
        }

        private void InitializeComponents()
        {
            portLabel.Parent = LoginBackgroundPic;
            portLabel.BackColor = Color.Transparent;

            ipLabel.Parent = LoginBackgroundPic;
            ipLabel.BackColor = Color.Transparent;

            ipPlaceHolderLabel.Parent = LoginBackgroundPic;
            ipPlaceHolderLabel.BackColor = Color.Transparent;
        }

        private void Initialize()
        {
            _myIpAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1];
            DataStatic.MyIP = _myIpAddress;

            ipPlaceHolderLabel.Text = _myIpAddress.ToString();
        }

        private void StartGame(object sender, EventArgs e)
        {
            this.Hide();
            Program.DIContainer.Resolve<MainBackground>().Subscribe(this).Show();
        }

        public void LoginDataChanged(object sender, EventArgs e)
        {
            _validateTextBoxData.ValidateLoginData();
        }

        private async void JoinGameButton_Click(object sender, EventArgs e)
        {
            DataStatic.ImAttacker = true;
            DataStatic.Me.Sign = Sign.Cross;

            DataStatic.Enemy.Sign = Sign.Circle;
            ((Enemy)DataStatic.Enemy).IP = IPAddress.Parse(ip.Text);
            DataStatic.Enemy.Port = int.Parse(port.Text);

            DataStatic.Port = int.Parse(port.Text);
            DataStatic.OponentIP = IPAddress.Parse(ip.Text);

            try
            {
                await _gameConnection.JoinConnectionAsync();
                OpenBoard();
            }
            catch (Exception ex)
            {
            }
        }

        private async void ExpectGameButton_Click(object sender, EventArgs e)
        {
            DataStatic.ImAttacker = false;
            DataStatic.Me.Sign = Sign.Circle;
            DataStatic.Me.Port = int.Parse(port.Text);

            DataStatic.Enemy.Sign = Sign.Cross;

            DataStatic.Port = int.Parse(port.Text);

            await _gameConnection.ExpectConnectionAsync();
            OpenBoard();
        }

        private void OpenBoard()
        {
            this.Hide();
            Program.DIContainer.Resolve<MainBackground>().Subscribe(this).Show();
        }

        private void StartPopup_Load(object sender, EventArgs e)
        {
            _validateTextBoxData = Program.DIContainer.Resolve<IValidateTextBoxData>();
            _gameConnection = Program.DIContainer.Resolve<IGameConnection>();
        }
    }
}
