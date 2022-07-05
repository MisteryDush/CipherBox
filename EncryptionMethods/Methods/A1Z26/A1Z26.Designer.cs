using System.ComponentModel;

namespace EncryptionMethods.Methods.A1Z26
{
    partial class A1Z26
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.RadioButton();
            this.decrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(42, 64);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(242, 334);
            this.inputBox.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.submitButton.Location = new System.Drawing.Point(315, 183);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(175, 76);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Proceed";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(519, 64);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(242, 334);
            this.outputBox.TabIndex = 2;
            // 
            // encrypt
            // 
            this.encrypt.Checked = true;
            this.encrypt.Location = new System.Drawing.Point(341, 82);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(104, 24);
            this.encrypt.TabIndex = 3;
            this.encrypt.TabStop = true;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(341, 130);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(104, 24);
            this.decrypt.TabIndex = 4;
            this.decrypt.TabStop = true;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(78, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(561, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A1Z26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputBox);
            this.Name = "A1Z26";
            this.Text = "A1Z26";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.RadioButton encrypt;
        private System.Windows.Forms.RadioButton decrypt;

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.TextBox inputBox;

        #endregion
    }
}