using erp.application.Commands.Login;
using MediatR;

namespace erp.desktopApp.Forms.Login;

public partial class FormLogin : Form
{
    private readonly IMediator _mediator;

    public FormLogin(IMediator mediator)
    {
        InitializeComponent();
        this.DialogResult = DialogResult.Cancel;
        _mediator = mediator;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            SetButtonsToDisabled(true);
            var user = await _mediator.Send(new LoginCommand { Username = txtLogin.Text, Password = txtPassword.Text });
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

    private void SetButtonsToDisabled(bool v)
    {
        btnClose.Enabled = !v;
        btnLogin.Enabled = !v;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
