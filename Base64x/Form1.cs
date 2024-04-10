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

        public void UTF8Entry_TextChanged(object sender, EventArgs e)
        {
        }

        private void BASE64Out_TextChanged(object sender, EventArgs e)
        {

        }

        // changes the process between encoding and decoding the text
        private void button1_Click(object sender, EventArgs e)
        {
            if (_swapState == State.Encode)
            {
                _swapState = State.Decode;
            }
            else
            {
                _swapState = State.Encode;
            }

            string BASE64text = BASE64TextBox.Text;
            string UTF8text = UTF8TextBox.Text;

            BASE64TextBox.Text = UTF8text;
            UTF8TextBox.Text = BASE64text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button handler = new CopyButton();
            handler.ClickToCopy(BASE64TextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
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