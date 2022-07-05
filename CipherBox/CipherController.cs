using System.Threading;
using System.Windows.Forms;
using EncryptionMethods.Methods.ROT13;

namespace CipherBox
{
    public static class CipherController
    {
        public static void buttonHandler(string text)
        {
            switch (text)
            {
                case "ROT13":
                    var window = new ROTWindow();
                    window.Show();
                    break;
            }
        }
    }
}