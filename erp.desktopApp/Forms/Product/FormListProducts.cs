using erp.application.Commands.DeleteProduct;
using erp.application.Queries.ListProducts;
using MediatR;
using Microsoft.Extensions.DependencyInjection;



namespace erp.desktopApp.Forms.Product
{
    public partial class FormListProducts : Form
    {
        private readonly IMediator _mediator;
        private IEnumerable<domain.Entities.Product> _products;
        private readonly ServiceProvider _serviceProvider;
        public FormListProducts(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _serviceProvider = ServiceProviderStatic.GetServiceProvider();
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

        private async void gridProducts_DoubleClick(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            await OpenEditCreateProduct(product);
        }

        private async Task OpenEditCreateProduct(domain.Entities.Product? product)
        {
            var form = _serviceProvider.GetRequiredService<FormEditProduct>();
            if (product != null)
                form.LoadFromProduct(product);
            form.ShowDialog();
            await LoadGrid();
        }

        private async Task OpenEditCreateProduct()
        {
            await OpenEditCreateProduct(null);
        }

        private domain.Entities.Product? GetSelectedProduct()
        {
            DataGridViewRow selectedRow = gridProducts.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["colId"].Value);
            return _products.FirstOrDefault(p => p.Id == id);
        }

        private async void btnNewProduct_Click(object sender, EventArgs e)
        {
            await OpenEditCreateProduct();
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            if (product is null) return;

            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            var command = new DeleteProductCommand(product.Id);
            await _mediator.Send(command);
            await LoadGrid();
        }

        private async void btnVizualize_Click(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            if (product is null) return;
            await OpenEditCreateProduct(product);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadGrid();
        }
    }
}
