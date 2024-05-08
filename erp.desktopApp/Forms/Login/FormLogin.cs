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
            var user = await _mediator.Send(new LoginCommand { Username = "admin", Password = "!123456"});
            GlobalInfo.SetCurrentUser(user);
            this.DialogResult = DialogResult.OK;
            this.Close();
        } catch(Exception ex)
        {
            MessageBox.Show(ex.Message);
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
