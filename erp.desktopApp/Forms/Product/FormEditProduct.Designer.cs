namespace erp.desktopApp.Forms.Product
{
    partial class FormEditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnDel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            txtPrice = new NumericUpDown();
            txtStock = new NumericUpDown();
            txtCost = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            txtBarCode = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCost).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 27);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "<Automatico>";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(12, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(352, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 97);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 41);
            panel1.TabIndex = 8;
            // 
            // btnDel
            // 
            btnDel.AccessibleName = "";
            btnDel.Dock = DockStyle.Left;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.ForeColor = Color.Black;
            btnDel.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnDel.IconColor = Color.Black;
            btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDel.IconSize = 32;
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(104, 0);
            btnDel.Name = "btnDel";
            btnDel.Padding = new Padding(10, 0, 20, 0);
            btnDel.Size = new Size(110, 41);
            btnDel.TabIndex = 7;
            btnDel.TabStop = false;
            btnDel.Text = "Delete";
            btnDel.TextAlign = ContentAlignment.MiddleLeft;
            btnDel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.AccessibleName = "";
            btnSave.Dock = DockStyle.Left;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 20, 0);
            btnSave.Size = new Size(104, 41);
            btnSave.TabIndex = 6;
            btnSave.TabStop = false;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.DecimalPlaces = 2;
            txtPrice.ImeMode = ImeMode.NoControl;
            txtPrice.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            txtPrice.Location = new Point(12, 115);
            txtPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.Size = new Size(172, 23);
            txtPrice.TabIndex = 4;
            txtPrice.ThousandsSeparator = true;
            txtPrice.Enter += txtPrice_Enter;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.ImeMode = ImeMode.NoControl;
            txtStock.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            txtStock.Location = new Point(192, 115);
            txtStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.RightToLeft = RightToLeft.Yes;
            txtStock.Size = new Size(172, 23);
            txtStock.TabIndex = 6;
            txtStock.ThousandsSeparator = true;
            txtStock.Enter += txtStock_Enter;
            // 
            // txtCost
            // 
            txtCost.DecimalPlaces = 2;
            txtCost.ImeMode = ImeMode.NoControl;
            txtCost.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            txtCost.Location = new Point(12, 159);
            txtCost.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtCost.Name = "txtCost";
            txtCost.RightToLeft = RightToLeft.Yes;
            txtCost.Size = new Size(172, 23);
            txtCost.TabIndex = 5;
            txtCost.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 9);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "Barcode";
            // 
            // txtBarCode
            // 
            txtBarCode.Location = new Point(132, 27);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(232, 23);
            txtBarCode.TabIndex = 2;
            // 
            // FormEditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 232);
            Controls.Add(txtBarCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCost);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditProduct";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEditProduct";
            Load += FormEditProduct_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnDel;
        private NumericUpDown txtPrice;
        private NumericUpDown txtStock;
        private NumericUpDown txtCost;
        private Label label5;
        private Label label6;
        private TextBox txtBarCode;
    }
}