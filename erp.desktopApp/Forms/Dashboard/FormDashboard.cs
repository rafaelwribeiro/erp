using erp.application.Commands.CreateProduct;
using erp.application.Commands.Orders.AddItem;
using erp.application.Commands.Orders.AddPaymentMethod;
using erp.application.Commands.Orders.ApplyDiscountShippingAditionalExpense;
using erp.application.Commands.Orders.ConfirmOrder;
using erp.application.Commands.Orders.New;
using erp.application.Commands.Orders.WaitingPayment;
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
            button2.Enabled = false;
            //inicia novo pedido
            var newOrderCmd = new NewOrderCommand
            {
                CustomerId = 1
            };
            var order = await _mediator.Send(newOrderCmd);

            if (order.Status != domain.Entities.OrderStatus.Created)
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
            addItemCmd = new AddItemCommand
            {
                OrderId = order.Id,
                ProductId = 3,
                Quantity = 5,
                UnitPrice = 7
            };
            order = await _mediator.Send(addItemCmd);


            //adiciona outro item
            addItemCmd = new AddItemCommand
            {
                OrderId = order.Id,
                ProductId = 4,
                Quantity = 5,
                UnitPrice = 20
            };
            order = await _mediator.Send(addItemCmd);

            //aplica desconto e taxa de entrega
            var applyDiscountGlobal = new ApplyDiscountShippingAditionalExpenseCommand
            {
                OrderId = order.Id,
                GlobalDiscount = 10,
                ShippingCost = 7
            };
            order = await _mediator.Send(applyDiscountGlobal);

            //move pedido para aguardando pagamento
            var moveToWaitingPayment = new MoveOrderToAwaitingPaymentCommand()
            {
                OrderId = order.Id
            };
            order = await _mediator.Send(moveToWaitingPayment);

            //add pagamento em cartão
            var addPaymentCreditCard = new AddPaymentMethodCommand
            {
                OrderId = order.Id,
                Amount = 10,
                PaymentMethodId = 1,
            };
            await _mediator.Send(addPaymentCreditCard);
            
            //add pagamento em cartão
            var addPaymentCash = new AddPaymentMethodCommand
            {
                OrderId = order.Id,
                Amount = 202,
                ReceivedAmount = 105,
                PaymentMethodId = 4,
            };
            await _mediator.Send(addPaymentCash);


            //confirmar order
            var confirm = new ConfirmOrderCommand
            {
                OrderId = order.Id
            };

            order = await _mediator.Send(confirm);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}\r\n{ex.InnerException}");
        }
        finally
        {
            button2.Enabled = true;
        }
    }
}
