using erp.application.Commands.Login;
using MediatR;
using erp.desktopApp.Extension;

namespace erp.desktopApp.Forms.Login;

public partial class FormLogin : Form
{
    private readonly IMediator _mediator;

    public FormLogin(IMediator mediator)
    {
        InitializeComponent();
        this.DialogResult = DialogResult.Cancel;
        _mediator = mediator;
        this.AddEnterKeyHandlerToAllControls();
    }

    private void SetButtonsToDisabled(bool v)
    {
        //btnClose.Enabled = !v;
        //btnLogin.Enabled = !v;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void txtUser_Click(object sender, EventArgs e)
    {
        txtUser.BackColor = Color.White;
        pnlUser.BackColor = Color.White;
        iconUser.BackColor = Color.White;

        txtPassword.BackColor = SystemColors.Control;
        pnlPassword.BackColor = SystemColors.Control;
        iconPassword.BackColor = SystemColors.Control;

        txtUser.Focus();
    }

    private void txtPassword_Click(object sender, EventArgs e)
    {
        txtUser.BackColor = SystemColors.Control;
        pnlUser.BackColor = SystemColors.Control;
        iconUser.BackColor = SystemColors.Control;

        txtPassword.BackColor = Color.White;
        pnlPassword.BackColor = Color.White;
        iconPassword.BackColor = Color.White;

        txtPassword.Focus();
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            SetButtonsToDisabled(true);
            var user = await _mediator.Send(new LoginCommand { Username = txtUser.Text, Password = txtPassword.Text });
            GlobalInfo.SetCurrentUser(user);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            SetButtonsToDisabled(false);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtUser.Clear();
        txtPassword.Clear();
        txtUser.Focus();
    }
}
