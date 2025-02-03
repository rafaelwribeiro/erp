using erp.application.Commands.CreateProduct;
using erp.application.Commands.NewOrder;
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
            var command = new NewOrderCommand
            {
                CustomerId = 1,
                AdditionalExpenses = 20,
                GlobalDiscount = 10,
                ShippingCost = 3
            };

            command.OrderItems = new List<NewOrderItem>
            {
                new NewOrderItem {
                    ProductId = 1,
                    Quantity = 4,
                    UnitPrice = 9.99m,
                    Discount = 10
                
                },
                new NewOrderItem {
                    ProductId = 3,
                    Quantity = 10,
                    UnitPrice = 25.50m,
                    Discount = 55
                }
            };

            var order = await _mediator.Send(command);

            // 242.96 valor esperado total
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}\r\n{ex.InnerException}");
        }

    }
}
