using System.Net;
using System.Windows.Forms;
using TicTacToe.Popup.Validate.Interfaces;

namespace TicTacToe.Popup.Validate
{
    public class ValidateTextBoxData : IValidateTextBoxData
    {
        private StartPopup _startPopup;
        private MaskedTextBox _ip;
        private MaskedTextBox _port;
        private Button _expectGameButton;
        private Button _joinGameButton;

        public ValidateTextBoxData(StartPopup startPopup)
        {
            _startPopup = startPopup;

            _ip = (MaskedTextBox)_startPopup.Controls["ip"];
            _port = (MaskedTextBox)_startPopup.Controls["port"];
            _expectGameButton = (Button)_startPopup.Controls["ExpectGameButton"];
            _joinGameButton = (Button)_startPopup.Controls["JoinGameButton"];
        }

        public void ValidateLoginData()
        {
            IPTextChanged();
            PortTextChanged();
        }

        private void IPTextChanged()
        {
            if (_ip.Text != string.Empty)
            {
                _expectGameButton.Enabled = false;

                if (!IPAddress.TryParse(_ip.Text, out IPAddress iPAddress))
                {
                    _joinGameButton.Enabled = false;
                }
                else
                {
                    _joinGameButton.Enabled = true;
                }
            }
            else
            {
                _expectGameButton.Enabled = true;
            }
        }

        private void PortTextChanged()
        {
            if (_port.Text != string.Empty && int.TryParse(_port.Text, out int portAdress))
            {
                _expectGameButton.Enabled = true;

                if (_ip.Text != string.Empty)
                {
                    _expectGameButton.Enabled = false;
                }
                else
                {
                    _joinGameButton.Enabled = false;
                }
            }
            else
            {
                _joinGameButton.Enabled = false;
                _expectGameButton.Enabled = false;
            }
        }

    }
}
