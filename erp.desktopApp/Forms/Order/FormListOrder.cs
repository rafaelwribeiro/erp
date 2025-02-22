using erp.application.Queries.ListOrders;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Linq;

namespace erp.desktopApp.Forms.Order
{
    public partial class FormListOrder : Form
    {
        private readonly IMediator _mediator;
        private readonly ServiceProvider _serviceProvider;
        private IEnumerable<domain.Entities.Order> _orders;

        public FormListOrder(IMediator mediator)
        {
            _mediator = mediator;
            _serviceProvider = ServiceProviderStatic.GetServiceProvider();
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void FormListOrder_Load(object sender, EventArgs e)
        {
            await LoadGrid();
        }

        private async Task LoadGrid()
        {
            gridOrders.Rows.Clear();
            _orders = await _mediator.Send(new ListOrderQuery());

            _orders.OrderByDescending(p => p.Id).ToList().ForEach(p =>
            {
                gridOrders.Rows.Add(p.Id,
                        p.Customer?.FullName,
                        p.Status.ToString(),
                        p.GlobalDiscount.ToString("C", new CultureInfo("pt-BR")),
                        p.Total.ToString("C", new CultureInfo("pt-BR")));
            });
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadGrid();
        }

        private async void btnNewProduct_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormEditOrder>();
            form.ShowDialog();
            await LoadGrid();
        }

        private async void gridOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = GetSelectecOrderId(e);

            if (id <= 0) return;

            var form = _serviceProvider.GetRequiredService<FormEditOrder>();
            await form.SetOrder(id);
            form.ShowDialog();
            await LoadGrid();
        }

        private int GetSelectecOrderId(DataGridViewCellEventArgs e)
        {
            var valor = gridOrders.Rows[e.RowIndex].Cells["colId"].Value;
            if (valor != null && int.TryParse(valor.ToString(), out int id))
                return id;
            return 0;
        }
    }
}
