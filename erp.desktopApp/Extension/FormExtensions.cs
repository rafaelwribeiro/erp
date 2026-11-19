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

    private static Icon? _applicationIcon;

    /// <summary>
    /// Gives a top-level form the icon embedded in the exe (app.ico), so the window
    /// and the taskbar show the same icon as the file. WinForms does not do this by
    /// itself: a form without an Icon gets the generic WinForms one.
    /// </summary>
    public static void UseApplicationIcon(this Form form)
    {
        _applicationIcon ??= Environment.ProcessPath is { } exe ? Icon.ExtractAssociatedIcon(exe) : null;
        if (_applicationIcon is null)
            return;

        form.Icon = _applicationIcon;
        // With ShowIcon off the taskbar falls back to a blank icon, even on a borderless form.
        form.ShowIcon = true;
    }
}
