using System.ComponentModel;

namespace EncryptionMethods.Methods.ROT13
{
    partial class ROTWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.RadioButton();
            this.decrypt = new System.Windows.Forms.RadioButton();
            this.steps = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.steps)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text here:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(41, 113);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(191, 87);
            this.inputBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(529, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter text here:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(529, 113);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(191, 87);
            this.outputBox.TabIndex = 3;
            // 
            // encrypt
            // 
            this.encrypt.Checked = true;
            this.encrypt.Location = new System.Drawing.Point(268, 114);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(104, 24);
            this.encrypt.TabIndex = 4;
            this.encrypt.TabStop = true;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(392, 114);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(104, 24);
            this.decrypt.TabIndex = 5;
            this.decrypt.TabStop = true;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // steps
            // 
            this.steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.steps.Location = new System.Drawing.Point(341, 165);
            this.steps.Maximum = new decimal(new int[] {26, 0, 0, 0});
            this.steps.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(58, 35);
            this.steps.TabIndex = 6;
            this.steps.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.submitButton.Location = new System.Drawing.Point(279, 323);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(178, 78);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Proceed";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ROTWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "ROTWindow";
            this.Text = "ROT";
            ((System.ComponentModel.ISupportInitialize) (this.steps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown steps;
        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton encrypt;
        private System.Windows.Forms.RadioButton decrypt;

        private System.Windows.Forms.TextBox outputBox;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}