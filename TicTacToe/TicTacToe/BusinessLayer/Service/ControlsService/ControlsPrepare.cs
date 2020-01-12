using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.BusinessLayer.Service.ControlsService.Interfaces;
using TicTacToe.BusinessLayer.Service.GameService.Interfaces;
using TicTacToe.Static;

namespace TicTacToe.BusinessLayer.BusinessLayer.Service.ControlsService
{
    public class ControlsPrepare : IControlsPrepare
    {
        private readonly MainBackground _form;
        private readonly IControlsRepository _controlsRepository;
        private readonly ITurnLogic _turnLogic;

        public ControlsPrepare(MainBackground form, IControlsRepository controlsRepository, ITurnLogic turnLogic)
        {
            _form = form;
            _controlsRepository = controlsRepository;
            _turnLogic = turnLogic;
        }

        /// <summary>
        /// Logic for button click
        /// </summary>
        /// <param name="sender">Actually button</param>
        /// <param name="eventArgs"></param>
        private void GameButtonClick(object sender, EventArgs eventArgs)
        {
            _turnLogic.ExecuteTurnAsync(_form, (Button)sender, DataStatic.Me);
        }

        public void PrepareButtonsGameEvents()
        {
            _controlsRepository.GetGameButtons(_form).ForEach(b => b.Click += GameButtonClick);
        }

        public void PrepareButtonsState()
        {
            if (!DataStatic.ImAttacker)
            {
                DataStatic.FreezeButtons(form: _form, withExceptionControls: _form.ProtectedControls.ToArray());
                _form.SetTurnMsg(DataStatic.Enemy);
            }
            else
            {
                _form.SetTurnMsg(DataStatic.Me);
            }
        }

        public void PreapareAll()
        {
            var methods = typeof(IControlsPrepare).GetMethods();

            foreach (var method in methods)
            {
                if (rightMethod(method))
                {
                    method.Invoke(this, null);
                }
            }

            bool rightMethod(MethodInfo method)
            {
                bool result = false;

                result = !method.IsGenericMethod && method.Name != "PreapareAll" && !method.GetParameters().Any();

                return result;
            }
        }
    }
}
