using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CipherBox
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cipherDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitCipher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cipherDropdown
            // 
            this.cipherDropdown.CausesValidation = false;
            this.cipherDropdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.cipherDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cipherDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cipherDropdown.FormattingEnabled = true;
            this.cipherDropdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cipherDropdown.Items.AddRange(new object[] {"ROT13", "A1Z26", "Vigenere Cipher", "Soon..."});
            this.cipherDropdown.Location = new System.Drawing.Point(380, 201);
            this.cipherDropdown.Name = "cipherDropdown";
            this.cipherDropdown.Size = new System.Drawing.Size(324, 33);
            this.cipherDropdown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(380, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an encryption method: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitCipher
            // 
            this.submitCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.submitCipher.Location = new System.Drawing.Point(422, 457);
            this.submitCipher.Name = "submitCipher";
            this.submitCipher.Size = new System.Drawing.Size(250, 81);
            this.submitCipher.TabIndex = 3;
            this.submitCipher.Text = "Proceed";
            this.submitCipher.UseVisualStyleBackColor = true;
            this.submitCipher.Click += new System.EventHandler(this.submitCipher_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1088, 631);
            this.Controls.Add(this.submitCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipherDropdown);
            this.Name = "MainWindow";
            this.Text = "Cipher Box";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button submitCipher;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cipherDropdown;

        #endregion
    }
}