using erp.application.Commands.NewStockMovement;
using MediatR;

namespace erp.desktopApp
{
    public partial class Form1 : Form
    {
        private readonly IMediator _mediator;
        public Form1(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var command = new NewStockMovementCommand { 
                ProductId = 2,
                Amount = 200,
                Description = "Just testing",
                Type = domain.Enumerators.StockMovementType.In
            };

            var stockMovement = await _mediator.Send(command);

            MessageBox.Show(stockMovement.Description);


        }
    }
}
