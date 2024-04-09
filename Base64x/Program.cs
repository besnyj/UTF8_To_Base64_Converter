﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Base64x
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    // manages the UTFEntry rich text box
    public class UTF8
    {
    }

    // manages the Base64Out rich text box
    public class Base64
    {
    }

    // manages the actions for the buttons swap and copy
    public class Button
    {
        public virtual void ClickToSwap()
        {
        }

        public virtual void ClickToCopy()
        {
        }

        public virtual string ClickToConvert(string text)
        {
            return "";
        }

        public virtual string ClickToRevert(string text)
        {
            return "";
        }
    }
    

    public class CopyButton : Button
    {
        public override void ClickToCopy()
        {
            
        }
    }
    
    public class EnterButton : Button
    {

        public override string ClickToConvert(string text)
        {
            return Converters.EncodeToBase64(text);
        }

        public override string ClickToRevert(string text)
        {
            return Converters.DecodeToUTF8(text);
        }
        
    }

    // manages the converters for UTF8 to Base64 back and fourth
    public static class Converters
    {
        public static string EncodeToBase64(string UTF8Text)
        {
            byte[] textToBeConverted = Encoding.UTF8.GetBytes(UTF8Text);
            string convertedText = Convert.ToBase64String(textToBeConverted);

            return convertedText;
        }

        public static string DecodeToUTF8(string Base64Text)
        {
            byte[] textToBeReverted = Convert.FromBase64String(Base64Text);
            string revertedText = Encoding.UTF8.GetString(textToBeReverted);

            return revertedText;
        }
    }
    
}