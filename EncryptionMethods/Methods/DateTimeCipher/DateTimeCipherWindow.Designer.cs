using System.ComponentModel;

namespace EncryptionMethods.Methods.DateTimeCipher
{
    partial class DateTimeCipherWindow
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
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.RadioButton();
            this.decrypt = new System.Windows.Forms.RadioButton();
            this.key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(38, 119);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(203, 161);
            this.input.TabIndex = 1;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(543, 119);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(203, 161);
            this.output.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(573, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.submit.Location = new System.Drawing.Point(313, 346);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(140, 66);
            this.submit.TabIndex = 4;
            this.submit.Text = "Proceed";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // encrypt
            // 
            this.encrypt.Checked = true;
            this.encrypt.Location = new System.Drawing.Point(266, 120);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(104, 24);
            this.encrypt.TabIndex = 5;
            this.encrypt.TabStop = true;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(400, 120);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(104, 24);
            this.decrypt.TabIndex = 6;
            this.decrypt.TabStop = true;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(313, 214);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(140, 26);
            this.key.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(329, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateTimeCipherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "DateTimeCipherWindow";
            this.Text = "DateTimeCipherWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RadioButton encrypt;
        private System.Windows.Forms.RadioButton decrypt;

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox input;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}