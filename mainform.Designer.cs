namespace BankHacks
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptedbankcodeinput = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.playerhandleinput = new System.Windows.Forms.TextBox();
            this.decryptedbankcodeinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encrypted Bank Code:";
            // 
            // encryptedbankcodeinput
            // 
            this.encryptedbankcodeinput.Location = new System.Drawing.Point(241, 38);
            this.encryptedbankcodeinput.Name = "encryptedbankcodeinput";
            this.encryptedbankcodeinput.Size = new System.Drawing.Size(415, 20);
            this.encryptedbankcodeinput.TabIndex = 3;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(671, 38);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(671, 69);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 5;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Button2_Click);
            // 
            // playerhandleinput
            // 
            this.playerhandleinput.Location = new System.Drawing.Point(241, 12);
            this.playerhandleinput.Name = "playerhandleinput";
            this.playerhandleinput.Size = new System.Drawing.Size(415, 20);
            this.playerhandleinput.TabIndex = 6;
            // 
            // decryptedbankcodeinput
            // 
            this.decryptedbankcodeinput.Location = new System.Drawing.Point(240, 69);
            this.decryptedbankcodeinput.Name = "decryptedbankcodeinput";
            this.decryptedbankcodeinput.Size = new System.Drawing.Size(416, 20);
            this.decryptedbankcodeinput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Decrypted Bank Code (Separated by Commas):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player Handle:";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(767, 102);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptedbankcodeinput);
            this.Controls.Add(this.playerhandleinput);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.encryptedbankcodeinput);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(783, 141);
            this.MinimumSize = new System.Drawing.Size(783, 141);
            this.Name = "mainform";
            this.Text = "Desert Tank Battle Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptedbankcodeinput;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.TextBox playerhandleinput;
        private System.Windows.Forms.TextBox decryptedbankcodeinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

