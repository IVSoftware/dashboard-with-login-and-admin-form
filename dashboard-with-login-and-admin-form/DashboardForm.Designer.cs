namespace dashboard_with_login_and_admin_form
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSignOut = new Button();
            buttonShowAdminForm = new Button();
            SuspendLayout();
            // 
            // buttonSignOut
            // 
            buttonSignOut.Location = new Point(24, 81);
            buttonSignOut.Name = "buttonSignOut";
            buttonSignOut.Size = new Size(209, 34);
            buttonSignOut.TabIndex = 0;
            buttonSignOut.Text = "Sign Out";
            buttonSignOut.UseVisualStyleBackColor = true;
            // 
            // buttonShowAdminForm
            // 
            buttonShowAdminForm.Location = new Point(24, 41);
            buttonShowAdminForm.Name = "buttonShowAdminForm";
            buttonShowAdminForm.Size = new Size(209, 34);
            buttonShowAdminForm.TabIndex = 0;
            buttonShowAdminForm.Text = "Show Admin Form";
            buttonShowAdminForm.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(buttonShowAdminForm);
            Controls.Add(buttonSignOut);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonSignOut;
        private Button buttonShowAdminForm;
    }
}
