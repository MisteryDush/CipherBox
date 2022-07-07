using System;
using System.Windows.Forms;

namespace EncryptionMethods.Methods.Vigenere_Cipher
{
    public partial class VigenereWindow : Form
    {
        public VigenereWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            outputBox.Text = VigenereLogic.Encrypt(inputBox.Text, encrypt.Checked, keyBox.Text);
        }
    }
}