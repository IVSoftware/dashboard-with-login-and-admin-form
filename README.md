## dashboard-with-login-and-admin-form

As I understand it, there is a LoginForm that is shown first, where a successful login will show the dashboard.

[Placeholder]

Then, by clicking on [Show Admin Form] that should go on top and stay there even if it loses focus by clicking back on the dashboard.

[Placeholder]

In order to make sure that I understand your situation, I made a repo you can [Clone]() to make sure it has the behavior you want.
___
What has worked for me when the Main Form is 'not' the first form shown is to force the creation of the Handle in the costructor so that the application is clear that it is the main window of the app.

```csharp
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
```

