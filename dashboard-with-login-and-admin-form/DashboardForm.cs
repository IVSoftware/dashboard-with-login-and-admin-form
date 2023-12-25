namespace dashboard_with_login_and_admin_form
{
    public partial class DashboardForm : Form
    {
        private LoginForm LoginForm { get; } = new LoginForm();
        private AdminForm AdminForm { get; } = new AdminForm();

        public DashboardForm()
        {
            InitializeComponent();
            // Ordinarily we don't get the handle until
            // window is shown. But we want it now.
            _ = Handle;
            // Call BeginInvoke on the new handle so as not to block the CTor.
            BeginInvoke(new Action(() => execLoginFlow()));
            // Ensure final disposal of child forms. 
            Disposed += (sender, e) =>
            {
                LoginForm.Dispose();
            };
            buttonSignOut.Click += (sender, e) => IsLoggedIn = false;
            AdminForm.FormClosing += (sender, e) =>
            {
                if(e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    AdminForm.Hide();
                }
            };
            buttonShowAdminForm.Click += (sender, e) => AdminForm.Show(this);
        }
        private void execLoginFlow()
        {
            Visible = false;
            while (!IsLoggedIn)
            {
                LoginForm.StartPosition = FormStartPosition.CenterScreen;
                if (DialogResult.Cancel == LoginForm.ShowDialog(this))
                {
                    switch (MessageBox.Show(
                        this,
                        "Invalid Credentials",
                        "Error",
                        buttons: MessageBoxButtons.RetryCancel))
                    {
                        case DialogResult.Cancel: Application.Exit(); return;
                        case DialogResult.Retry: break;
                    }
                }
                else
                {
                    IsLoggedIn = true;
                }
            }
        }

        bool _isLoggedIn = false;
        public bool IsLoggedIn
        {
            get => _isLoggedIn;
            set
            {
                if (!Equals(_isLoggedIn, value))
                {
                    _isLoggedIn = value;
                    onIsLoggedInChanged();
                }
            }
        }
        private void onIsLoggedInChanged()
        {
            if (IsLoggedIn)
            {
                // WindowState = FormWindowState.Maximized;
                Text = $"Welcome {LoginForm.UserName}";
                Visible = true;
            }
            else execLoginFlow();
        }
    }
}
