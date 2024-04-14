using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base64x;

namespace Base64x
{
    public partial class Form1 : Form
    {
        public enum State
        {
            Encode,
            Decode,
        }

        public State _swapState = State.Encode;
        
        public Form1()
        {
            InitializeComponent();
        }

        // changes the process between encoding and decoding the text
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

            string BASE64text = BASE64TextBox.Text;
            string UTF8text = UTF8TextBox.Text;
            

            BASE64TextBox.Text = UTF8text;
            UTF8TextBox.Text = BASE64text;
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
                    BASE64TextBox.Text = handler.ClickToRevert(UTF8TextBox.Text);
                }
                
            }
        }
    }
}