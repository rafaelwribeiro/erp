using erp.domain.Entities;

namespace erp.desktopApp.Forms.Order;

public class FormOrderItem : Panel
{
    private readonly OrderItem _item;
    private Label lblName;

    public FormOrderItem(OrderItem item)
    {
        _item = item;
        //this.Padding = new Padding(10);
        //this.Size = new Size(300, 100);
        InitComponents();
        UpdateUI();
    }

    private void UpdateUI()
    {
        this.lblName.Text = _item?.Product?.Name ?? " ... ";
    }

    private void InitComponents()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        lblName = new Label();
        //lblName.Location = new Point(10, 10);
        //lblName.AutoSize = true;
        this.Controls.Add(lblName);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Criando um objeto Pen para desenhar a borda
        using (Pen borderPen = new Pen(Color.Black, 2)) // 2 é a espessura da borda
        {
            // Desenhando a borda do painel
            e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
