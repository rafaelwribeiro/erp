using erp.application.Commands.CreateProduct;
using erp.application.Commands.Orders.AddItem;
using erp.application.Commands.Orders.New;
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
        try
        {
            var command = new CreateProductCommand
            {
                Name = "Teste",
                Price = 9.50m
            };

            var product = await _mediator.Send(command);
            label1.Text = $"{product.Id} - {product.Name}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        try
        {
            var newOrderCmd = new NewOrderCommand
            {
                CustomerId = 1
            };

            var order = await _mediator.Send(newOrderCmd);

            if (order.Status != domain.Entities.OrderStatus.Processing)
                return;

            var addItemCmd = new AddItemCommand
            {
                OrderId = order.Id,
                ProductId = 1,
                Quantity = 10,
                UnitPrice = 10,
                Discount = 2
            };

            order = await _mediator.Send(addItemCmd);


            // 242.96 valor esperado total
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}\r\n{ex.InnerException}");
        }

    }
}
