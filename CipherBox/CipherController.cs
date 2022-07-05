using System.Threading;
using System.Windows.Forms;
using EncryptionMethods.Methods.A1Z26;
using EncryptionMethods.Methods.ROT13;

namespace CipherBox
{
    public static class CipherController
    {
        public static void buttonHandler(string text)
        {
            dynamic window;
            switch (text)
            {
                case "ROT13":
                    window = new ROTWindow();
                    window.Show();
                    break;
                case "A1Z26":
                    window = new A1Z26();
                    window.Show();
                    break;
            }
        }
    }
}