namespace erp.desktopApp.Extension;

internal static class FormExtensions
{
    public static void AddEnterKeyHandlerToAllControls(this Control control)
    {
        foreach (Control c in control.Controls)
        {
            // Adiciona o manipulador de eventos aos controles de entrada
            if (c is TextBox || c is ComboBox)
            {
                c.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true; // Impede o som de 'beep'
                        control.SelectNextControl((Control)sender, true, true, true, true);
                    }
                    else if (e.KeyCode == Keys.Escape)
                    {
                        e.SuppressKeyPress = true; // Impede o som de 'beep'
                        control.SelectNextControl((Control)sender, false, true, true, true);
                    }
                };
            }

            // Recursivamente adiciona o evento aos controles filhos
            if (c.HasChildren)
            {
                c.AddEnterKeyHandlerToAllControls();
            }
        }
    }

    public static void AddSelectAllTextOnEnterHandler(this Control control)
    {
        foreach (Control c in control.Controls)
        {
            if (c is TextBox || c is ComboBox)
            {
                c.Enter += (sender, e) =>
                {
                    if (sender is TextBox textBox)
                    {
                        textBox.SelectAll();
                    }
                    else if (sender is ComboBox comboBox && comboBox.DropDownStyle != ComboBoxStyle.DropDownList)
                    {
                        comboBox.SelectAll();
                    }
                };
            }

            // Recursivamente adiciona o evento aos controles filhos
            if (c.HasChildren)
            {
                c.AddSelectAllTextOnEnterHandler();
            }
        }
    }
}
