using System;
using System.Windows.Forms;

namespace Base64x
{
    public partial class Form1 : Form
    {
        public enum State
        {
            Encode,
            Decode,
        }

        private State _swapState = State.Encode;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void SwapButton_Click(object sender, EventArgs e)
        {
            if (_swapState == State.Encode)
            {
                _swapState = State.Decode;
                TopLabel.Text = "BASE64";
                BottomLabel.Text = "UTF8";
            }
            else
            {
                _swapState = State.Encode;
                TopLabel.Text = "UTF8";
                BottomLabel.Text = "BASE64";
            }

            string base64Text = BASE64TextBox.Text;
            string utf8Text = UTF8TextBox.Text;
            

            BASE64TextBox.Text = utf8Text;
            UTF8TextBox.Text = base64Text;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Button handler = new CopyButton();
            handler.ClickToCopy(BASE64TextBox.Text);
        }

        private void UTF8TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button handler = new EnterButton();

                if (_swapState == State.Encode)
                { 
                    BASE64TextBox.Text = handler.ClickToConvert(UTF8TextBox.Text);
                }
                else
                {
                    try
                    {
                        BASE64TextBox.Text = handler.ClickToRevert(UTF8TextBox.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid BASE64 input", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}