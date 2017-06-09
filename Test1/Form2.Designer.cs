namespace Test1
{
    partial class formPassword
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
            this.enterPassword = new System.Windows.Forms.Label();
            this.textPasword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.comfirmPassword = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPassword
            // 
            this.enterPassword.AutoSize = true;
            this.enterPassword.Location = new System.Drawing.Point(12, 12);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(81, 13);
            this.enterPassword.TabIndex = 0;
            this.enterPassword.Text = "Enter Password";
            // 
            // textPasword
            // 
            this.textPasword.Location = new System.Drawing.Point(117, 9);
            this.textPasword.Name = "textPasword";
            this.textPasword.Size = new System.Drawing.Size(232, 20);
            this.textPasword.TabIndex = 1;
            this.textPasword.UseSystemPasswordChar = true;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Location = new System.Drawing.Point(117, 61);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(232, 20);
            this.textConfirmPassword.TabIndex = 3;
            this.textConfirmPassword.UseSystemPasswordChar = true;
            // 
            // comfirmPassword
            // 
            this.comfirmPassword.AutoSize = true;
            this.comfirmPassword.Location = new System.Drawing.Point(12, 64);
            this.comfirmPassword.Name = "comfirmPassword";
            this.comfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.comfirmPassword.TabIndex = 2;
            this.comfirmPassword.Text = "Confirm Password";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 104);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(155, 26);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(194, 104);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 26);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // formPassword
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 142);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.comfirmPassword);
            this.Controls.Add(this.textPasword);
            this.Controls.Add(this.enterPassword);
            this.Name = "formPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPassword;
        private System.Windows.Forms.TextBox textPasword;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Label comfirmPassword;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}