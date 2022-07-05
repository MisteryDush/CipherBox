using System;
using System.Windows.Forms;

namespace CipherBox
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitCipher_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cipherDropdown.Text)) MessageBox.Show(@"Please, choose encryption method!");
            else
            {
                CipherController.buttonHandler(cipherDropdown.Text);
            }
        }
    }
}