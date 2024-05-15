namespace erp.desktopApp.Forms.Product
{
    partial class FormListProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gridProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnRemove = new FontAwesome.Sharp.IconButton();
            btnNewProduct = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridProducts
            // 
            gridProducts.AllowUserToAddRows = false;
            gridProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridProducts.BorderStyle = BorderStyle.None;
            gridProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice, colStock });
            gridProducts.Location = new Point(-2, 53);
            gridProducts.MultiSelect = false;
            gridProducts.Name = "gridProducts";
            gridProducts.ReadOnly = true;
            gridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProducts.Size = new Size(800, 396);
            gridProducts.TabIndex = 0;
            gridProducts.DoubleClick += gridProducts_DoubleClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Resizable = DataGridViewTriState.False;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Resizable = DataGridViewTriState.False;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Resizable = DataGridViewTriState.False;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnNewProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Left;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnRemove.IconColor = Color.Black;
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 24;
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(113, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 52);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Product";
            btnRemove.TextAlign = ContentAlignment.MiddleLeft;
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnNewProduct
            // 
            btnNewProduct.Dock = DockStyle.Left;
            btnNewProduct.FlatStyle = FlatStyle.Flat;
            btnNewProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnNewProduct.IconColor = Color.Black;
            btnNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewProduct.IconSize = 24;
            btnNewProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewProduct.Location = new Point(0, 0);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(113, 52);
            btnNewProduct.TabIndex = 0;
            btnNewProduct.Text = "New Product";
            btnNewProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnNewProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNewProduct.UseVisualStyleBackColor = true;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // FormListProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gridProducts);
            Name = "FormListProducts";
            Text = "Products";
            Activated += FormListProducts_Activated;
            Load += FormListProducts_Load;
            ((System.ComponentModel.ISupportInitialize)gridProducts).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridProducts;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private FontAwesome.Sharp.IconButton btnNewProduct;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}