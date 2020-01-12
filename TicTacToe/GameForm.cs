using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Service.ControlsService.Interfaces;

namespace TicTacToe
{
    public partial class MainBackground : Form
    {
        private const string TOP_TURUN_MSG_ME = "Your turn";
        private const string TOP_TURUN_MSG_ENEMY = "Enemy turn";

        private readonly List<Form> _forms = new List<Form>();

        public List<Control> ProtectedControls;

        public IControlsPrepare ControlsPrepare { get; set; }

        public MainBackground()
        {
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();

            ProtectedControls = new List<Control>
            {
                YouScore,
                EnemyScore,
                You,
                Enemy,
                TurnMsg,
                gameBoard
            };
        }

        public void SetTurnMsg(BusinessLayer.Model.Player playerTurn)
        {
            if (playerTurn == Static.DataStatic.Me)
            {
                TurnMsg.Text = TOP_TURUN_MSG_ME;
            }
            else
            {
                TurnMsg.Text = TOP_TURUN_MSG_ENEMY;
            }
        }

        public void UpdateScore(int youScore, int enemyScore)
        {
            YouScore.Text = youScore.ToString();
            EnemyScore.Text = enemyScore.ToString();
        }

        public Form Subscribe(Form form)
        {
            _forms.Add(form);

            return this;
        }

        private void Exit(object sender, FormClosedEventArgs e) => _forms.ForEach(form => form.Close());

        private void MainBackground_Loaded(object sender, EventArgs e)
        {
            //Preparing system...
            ControlsPrepare = Program.DIContainer.Resolve<IControlsPrepare>();

            ControlsPrepare.PreapareAll();
        }
    }
}
