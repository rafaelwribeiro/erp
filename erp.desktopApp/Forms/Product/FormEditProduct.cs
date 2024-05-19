using erp.application.Commands.CreateProduct;
using erp.application.Commands.DeleteProduct;
using erp.application.Commands.UpdateProduct;
using MediatR;
using erp.desktopApp.Extension;

namespace erp.desktopApp.Forms.Product;

public partial class FormEditProduct : Form
{
    private readonly IMediator _mediator;
    private bool IsInsert;
    public FormEditProduct(IMediator mediator)
    {
        InitializeComponent();
        this.AddEnterKeyHandlerToAllControls();
        this.AddSelectAllTextOnEnterHandler();
        _mediator = mediator;
        IsInsert = true;
    }

    public void LoadFromProduct(domain.Entities.Product product)
    {
        IsInsert = false;
        txtId.Text = product.Id.ToString();
        txtName.Text = product.Name.ToString();
        txtPrice.Text = product.Price.ToString();
        txtStock.Text = product.StockQuantity.ToString();
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (IsInsert)
                await SendInsertCommand();
            else
                await SendUpdateCommand();
            IsInsert = true;
            MessageBox.Show("Produto salvo com sucesso");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private async Task SendUpdateCommand()
    {
        var command = new UpdateProductCommand
        {
            Id = int.Parse(txtId.Text),
            Name = txtName.Text,
            Price = txtPrice.Value
        };
        await _mediator.Send(command);
    }

    private async Task SendInsertCommand()
    {
        var command = new CreateProductCommand
        {
            Name = txtName.Text,
            Price = txtPrice.Value,
            StockQuantity = Convert.ToInt32(txtStock.Value)
        };
        var product = await _mediator.Send(command);
        txtId.Text = product.Id.ToString();
    }

    private async void btnDel_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result != DialogResult.Yes)
            return;

        var id = int.Parse(txtId.Text);
        var command = new DeleteProductCommand(id);
        await _mediator.Send(command);

        this.Close();
    }

    private void FormEditProduct_Load(object sender, EventArgs e)
    {
        txtStock.ReadOnly = !IsInsert;

        this.Text = IsInsert ? "Create new product" : "Edit product";
    }

    private void txtPrice_Enter(object sender, EventArgs e)
    {
        //txtPrice.Select(0, txtPrice.Text.Length);
    }

    private void txtStock_Enter(object sender, EventArgs e)
    {
        //txtStock.Select(0, txtPrice.Text.Length);
    }
}
