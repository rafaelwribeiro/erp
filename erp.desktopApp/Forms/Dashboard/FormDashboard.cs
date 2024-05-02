using erp.application.Commands.CreateProduct;
using MediatR;

namespace erp.desktopApp.Forms.Dashboard;

public partial class FormDashboard : Form
{
    private readonly IMediator _mediator;

    public FormDashboard(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var command = new CreateProductCommand
        {
            Name = "Teste",
            Price = 9.50m
        };

        var product = await _mediator.Send(command);
        label1.Text = $"{product.Id} - {product.Name}";
    }
}
