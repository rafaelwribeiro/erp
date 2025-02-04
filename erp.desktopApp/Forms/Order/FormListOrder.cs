using erp.application.Queries.ListOrders;
using erp.application.Queries.ListProducts;
using erp.domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp.desktopApp.Forms.Order
{
    public partial class FormListOrder : Form
    {
        private readonly IMediator _mediator;
        private IEnumerable<domain.Entities.Order> _orders;

        public FormListOrder(IMediator mediator)
        {
            _mediator = mediator;
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

            _orders.ToList().ForEach(p =>
            {
                gridOrders.Rows.Add(p.Id,
                        p.Customer?.FullName,
                        p.GlobalDiscount.ToString("C", new CultureInfo("pt-BR")),
                        p.Total.ToString("C", new CultureInfo("pt-BR")));
            });
        }
    }
}
