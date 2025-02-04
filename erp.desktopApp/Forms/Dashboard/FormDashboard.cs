using erp.application.Commands.CreateProduct;
using erp.application.Commands.Orders.AddItem;
using erp.application.Commands.Orders.ApplyDiscountShippingAditionalExpense;
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
            //inicia novo pedido
            var newOrderCmd = new NewOrderCommand
            {
                CustomerId = 1
            };
            var order = await _mediator.Send(newOrderCmd);

            if (order.Status != domain.Entities.OrderStatus.Processing)
                return;

            //adiciona um item
            var addItemCmd = new AddItemCommand
            {
                OrderId = order.Id,
                ProductId = 1,
                Quantity = 10,
                UnitPrice = 10,
                Discount = 2
            };
            order = await _mediator.Send(addItemCmd);

            //adiciona outro item
            addItemCmd.ProductId = 3;
            addItemCmd.Quantity = 5;
            addItemCmd.UnitPrice = 7;
            addItemCmd.Discount = 0;
            order = await _mediator.Send(addItemCmd);

            //aplica desconto e taxa de entrega
            var applyDiscountGlobal = new ApplyDiscountShippingAditionalExpenseCommand
            {
                OrderId = order.Id,
                GlobalDiscount = 10,
                ShippingCost = 7
            };
            order = await _mediator.Send(applyDiscountGlobal);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}\r\n{ex.InnerException}");
        }

    }
}
