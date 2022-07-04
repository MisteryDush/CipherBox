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
            MessageBox.Show(string.IsNullOrEmpty(cipherDropdown.Text)
                ? "Please, choose encryption method!"
                : cipherDropdown.Text);
        }
    }
}