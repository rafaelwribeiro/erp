using erp.application.Commands.Orders.AddItem;
using erp.application.Commands.Orders.New;
using erp.application.Commands.Orders.WaitingPayment;
using erp.application.Queries.ListOrders;
using erp.application.Queries.ListProducts;
using erp.desktopApp.Forms.Order;
using erp.domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace erp.desktopApp;

public partial class FormEditOrder : Form
{
    private readonly IMediator _mediator;
    private readonly ServiceProvider _serviceProvider;
    private Order? _order;
    public FormEditOrder(IMediator mediator)
    {
        _mediator = mediator;
        _order = null;
        _serviceProvider = ServiceProviderStatic.GetServiceProvider();
        InitializeComponent();
    }

    public async Task SetOrder(int orderId)
    {
        var orders = await _mediator.Send(new ListOrderQuery
        {
            Id = orderId
        });

        _order = orders.FirstOrDefault();
    }

    private async void FormEditOrder_Shown(object sender, EventArgs e)
    {
        textBox1.Focus();

        if (_order is null)
            _order = await _mediator.Send(new NewOrderCommand
            {
                CustomerId = 1
            });
        UpdateUI();
    }

    private void UpdateUI()
    {
        ListItens();
        lblId.Text = $"{_order.Id}";
        lblTotal.Text = _order.Total.ToString("C");
        lblStatus.Text = _order.Status.ToString();
        lblConsumidor.Text = _order?.Customer?.FullName ?? ". . .";

        textBox1.Clear();
        textBox1.Focus();
    }

    private async void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        try
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            var barcode = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(barcode)) return;

            e.Handled = true;

            Product? prod = await GetItem(barcode);

            if (prod is null) return;

            await AddItemToOrder(prod);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro -> {ex.Message}");
        }
        finally
        {
            UpdateUI();
        }
    }

    private void ListItens()
    {
        pnlItens.Controls.Clear();
        var itens = _order.OrderItems;
        foreach (var item in itens)
            AddItemToPanel(item);
    }

    private void AddItemToPanel(OrderItem item)
    {
        var panel = new FormOrderItem(item);
        pnlItens.Controls.Add(panel);
        panel.Height = 30;
        panel.Width = panel?.Parent?.Width - 10 ?? 100;
    }

    private async Task AddItemToOrder(Product prod)
    {
        _order = await _mediator.Send(new AddItemCommand
        {
            OrderId = _order.Id,
            ProductId = prod.Id,
            Quantity = 1,
            UnitPrice = prod.Price,
            Discount = 0
        });
    }

    private async Task<Product?> GetItem(string barcode)
    {
        var products = await _mediator.Send(new ListProductsQuery()
        {
            Barcode = barcode
        });

        if (products is null) return null;

        if (products.Count() != 1) return null;

        var product = products.ToList().FirstOrDefault();

        return product;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var moveToWaitingPayment = new MoveOrderToAwaitingPaymentCommand()
            {
                OrderId = _order.Id
            };
            _order = await _mediator.Send(moveToWaitingPayment);
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Erro -> {ex.Message}");
        }
        finally
        {
            UpdateUI();
        }
    }
}
