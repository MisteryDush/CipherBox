using System;
using System.Windows.Forms;

namespace EncryptionMethods.Methods.A1Z26
{
    public partial class A1Z26 : Form
    {
        public A1Z26()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = A1Z26Logic.Encrypt(inputBox.Text, encrypt.Checked);
        }
    }
}