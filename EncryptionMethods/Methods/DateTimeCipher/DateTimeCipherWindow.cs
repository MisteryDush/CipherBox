using System;
using System.Windows.Forms;

namespace EncryptionMethods.Methods.DateTimeCipher
{
    public partial class DateTimeCipherWindow : Form
    {
        public DateTimeCipherWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var arr = DateTimeCipherLogic.Controller(encrypt.Checked, input.Text, key.Text);
            output.Text = arr[0];
            key.Text = arr[1];
        }
    }
}