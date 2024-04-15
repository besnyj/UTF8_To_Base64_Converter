using System;
using System.Text;
using System.Windows.Forms;



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
    
    // manages the actions for the buttons swap and copy
    public class Button
    {

        public virtual void ClickToCopy(string text)
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
        public override void ClickToCopy(string text)
        {
            Clipboard.SetData(DataFormats.Text, text);
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
            return Converters.DecodeToUtf8(text);
        }
        
    }

    // manages the converters for UTF8 to Base64 back and fourth
    public static class Converters
    {
        public static string EncodeToBase64(string utf8Text)
        {
            byte[] textToBeConverted = Encoding.UTF8.GetBytes(utf8Text);
            string convertedText = Convert.ToBase64String(textToBeConverted);

            return convertedText;
        }

        public static string DecodeToUtf8(string base64Text)
        {
            byte[] textToBeReverted = Convert.FromBase64String(base64Text);
            string revertedText = Encoding.UTF8.GetString(textToBeReverted);

            return revertedText;
        }
    }
    
}