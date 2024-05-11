using erp.crosscutting.AppDependencies;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;
using erp.desktopApp.Forms.Dashboard;
using erp.desktopApp.Forms.Login;
using erp.desktopApp.Forms.Product;
using System.Windows.Forms;

namespace erp.desktopApp;

public partial class FormMainMenu : Form
{
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;
    private ServiceProvider serviceProvider;
    public FormMainMenu()
    {
        InitializeComponent();
        leftBorderBtn = new Panel
        {
            Size = new Size(7, 60)
        };
        panelMenu.Controls.Add(leftBorderBtn);

        //Form
        this.Text = string.Empty;
        this.ControlBox = false;
        this.DoubleBuffered = true;
        this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        serviceProvider = ServiceProviderStatic.GetServiceProvider();
    }

    //Structs
    private struct RGBColors
    {
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
    }

    private void ActivateButton(object senderBtn, Color color)
    {
        if (senderBtn is null) return;

        DisableButton();
        currentBtn = (IconButton)senderBtn;
        currentBtn.BackColor = Color.FromArgb(37, 36, 81);
        currentBtn.ForeColor = color;
        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        currentBtn.IconColor = color;
        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentBtn.ImageAlign = ContentAlignment.MiddleRight;

        //left border button
        leftBorderBtn.BackColor = color;
        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        leftBorderBtn.Visible = true;
        leftBorderBtn.BringToFront();

        //Icon Current Child Form
        iconCurrentChildForm.IconChar = currentBtn.IconChar;
        iconCurrentChildForm.IconColor = color;
    }

    private void DisableButton()
    {
        if (currentBtn is null) return;

        currentBtn.BackColor = Color.FromArgb(31, 30, 68);
        currentBtn.ForeColor = Color.Gainsboro;
        currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        currentBtn.IconColor = Color.Gainsboro;
        currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
    }

    private void OpenChildForm(Form childForm)
    {
        if (currentChildForm != null)
        {
            currentChildForm.Close();
        }
        currentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        lblTitleChildForm.Text = childForm.Text;
    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        var form = serviceProvider.GetRequiredService<FormDashboard>();
        OpenChildForm(form);
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        var form = serviceProvider.GetRequiredService<FormListProducts>();
        OpenChildForm(form);
    }

    private void btnCustomers_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
    }

    private void btnHome_Click(object sender, EventArgs e)
    {
        currentChildForm?.Close();
        Reset();
    }

    private void Reset()
    {
        DisableButton();
        leftBorderBtn.Visible = false;
        iconCurrentChildForm.IconChar = IconChar.Home;
        iconCurrentChildForm.IconColor = Color.MediumPurple;
        lblTitleChildForm.Text = "Home";
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void panelTitledBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnMaximize_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            WindowState = FormWindowState.Maximized;
        else
            WindowState = FormWindowState.Normal;
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void FormMainMenu_Activated(object sender, EventArgs e)
    {
        
    }
}