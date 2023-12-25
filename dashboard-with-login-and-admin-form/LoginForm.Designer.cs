namespace dashboard_with_login_and_admin_form
{
    partial class LoginForm
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
            textBoxUid = new TextBox();
            label1 = new Label();
            textBoxPswd = new TextBox();
            label2 = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUid
            // 
            textBoxUid.Location = new Point(144, 54);
            textBoxUid.Name = "textBoxUid";
            textBoxUid.Size = new Size(237, 31);
            textBoxUid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 57);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 1;
            label1.Text = "User Id";
            // 
            // textBoxPswd
            // 
            textBoxPswd.Location = new Point(144, 100);
            textBoxPswd.Name = "textBoxPswd";
            textBoxPswd.PasswordChar = '*';
            textBoxPswd.Size = new Size(237, 31);
            textBoxPswd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 103);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Enabled = false;
            buttonLogin.Location = new Point(269, 187);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 2;
            buttonLogin.TabStop = false;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPswd);
            Controls.Add(textBoxUid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
    }
}