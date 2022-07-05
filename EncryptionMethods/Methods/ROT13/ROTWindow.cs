using System;
using System.Windows.Forms;

namespace EncryptionMethods.Methods.ROT13
{
    public partial class ROTWindow : Form
    {
        public ROTWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputBox.Text)) MessageBox.Show("Please, enter the phrase");
            else outputBox.Text = ROTLogic.Rot(inputBox.Text, encrypt.Checked, (int)steps.Value);
        }
    }
}