using erp.application.Queries.ListProducts;
using MediatR;



namespace erp.desktopApp.Forms.Product
{
    public partial class FormListProducts : Form
    {
        private readonly IMediator _mediator;
        private IEnumerable<domain.Entities.Product> _products;
        public FormListProducts(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void FormListProducts_Activated(object sender, EventArgs e)
        {

        }

        private async void FormListProducts_Load(object sender, EventArgs e)
        {
            await LoadGrid();
        }

        private async Task LoadGrid()
        {
            gridProducts.Rows.Clear();
            _products = await _mediator.Send(new ListProductsQuery());

            _products.ToList().ForEach(p =>
            {
                gridProducts.Rows.Add(p.Id, p.Name, p.Price, p.StockQuantity);
            });
        }

        private void gridProducts_DoubleClick(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            MessageBox.Show(product?.Name ?? "xD");
        }

        private domain.Entities.Product? GetSelectedProduct()
        {
            DataGridViewRow selectedRow = gridProducts.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["colId"].Value);
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
