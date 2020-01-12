using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.Extensions;
using TicTacToe.Mapping.Interfaces;

namespace TicTacToe.Mapping
{
    public class ControlsMapping : IControlsMapping
    {
        private readonly MainBackground _mainBackground;
        private readonly IControlsRepository _controlsRepository;

        public ControlsMapping(MainBackground mainBackground, IControlsRepository controlsRepository)
        {
            _mainBackground = mainBackground;
            _controlsRepository = controlsRepository;

            FillMapppings();
        }

        private void FillMapppings()
        {
            const string btnNamePrefix = "gameButton";

            var buttons = _controlsRepository.GetGameButtons(_mainBackground);

            int vertical = 0;       //pion
            int horizontal = 0;     //poziom
            for (int i = 1; i <= buttons.Count; i++)
            {
                var button = buttons.Single(b => b.Name == (btnNamePrefix + i));
                GameButtonToPointMapping.Add(button, getPoint());
            }

            (int, int) getPoint()
            {
                if (vertical == Math.Sqrt(buttons.Count))
                {
                    vertical = 0;
                    horizontal++;
                }

                return (vertical++, horizontal);
            }
        }

        public byte ButtonToByte(Button button)
        {
            return button.ToByte();
        }

        public Button ByteToButton(byte buttonNum)
        {
            return buttonNum.GetButton(_controlsRepository.GetGameButtons(_mainBackground));
        }

        public Dictionary<Button, (int vertical, int horizontal)> GameButtonToPointMapping { get; private set; } = new Dictionary<Button, (int, int)>();
    }
}
