using System;
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
    public abstract class Button
    {
        public virtual string ClickToSwap(string textFromEntryBox)
        {
            return "";
        }

        public virtual void ClickToCopy()
        {
        }
    }

    public class SwapButton : Button
    {
        public override string ClickToSwap(string textFromEntryBox)
        {
            return Converters.EncodeToBase64(textFromEntryBox);
        }
    }

    public class CopyButton : Button
    {
        public override void ClickToCopy()
        {
            
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
            return "";
        }
    }
}