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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gridProducts = new DataGridView();
            panel1 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnVizualize = new FontAwesome.Sharp.IconButton();
            btnRemove = new FontAwesome.Sharp.IconButton();
            btnNewProduct = new FontAwesome.Sharp.IconButton();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            BarCode = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
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
            gridProducts.BackgroundColor = Color.Gainsboro;
            gridProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, BarCode, colPrice, colStock });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridProducts.DefaultCellStyle = dataGridViewCellStyle3;
            gridProducts.GridColor = Color.Gainsboro;
            gridProducts.Location = new Point(-2, 44);
            gridProducts.MultiSelect = false;
            gridProducts.Name = "gridProducts";
            gridProducts.ReadOnly = true;
            gridProducts.RowHeadersVisible = false;
            gridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProducts.Size = new Size(800, 405);
            gridProducts.TabIndex = 0;
            gridProducts.CellContentClick += gridProducts_CellContentClick;
            gridProducts.DoubleClick += gridProducts_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnVizualize);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnNewProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Left;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 24;
            btnSearch.Location = new Point(375, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 45);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Atualizar";
            btnSearch.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnVizualize
            // 
            btnVizualize.Dock = DockStyle.Left;
            btnVizualize.FlatAppearance.BorderSize = 0;
            btnVizualize.FlatStyle = FlatStyle.Flat;
            btnVizualize.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnVizualize.IconColor = Color.Black;
            btnVizualize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVizualize.IconSize = 24;
            btnVizualize.Location = new Point(244, 0);
            btnVizualize.Name = "btnVizualize";
            btnVizualize.Size = new Size(131, 45);
            btnVizualize.TabIndex = 2;
            btnVizualize.Text = "Vizualizar";
            btnVizualize.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVizualize.UseVisualStyleBackColor = true;
            btnVizualize.Click += btnVizualize_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Left;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnRemove.IconColor = Color.Black;
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 24;
            btnRemove.Location = new Point(113, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 45);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Excluir";
            btnRemove.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnNewProduct
            // 
            btnNewProduct.Dock = DockStyle.Left;
            btnNewProduct.FlatAppearance.BorderSize = 0;
            btnNewProduct.FlatStyle = FlatStyle.Flat;
            btnNewProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnNewProduct.IconColor = Color.Black;
            btnNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewProduct.IconSize = 24;
            btnNewProduct.Location = new Point(0, 0);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(113, 45);
            btnNewProduct.TabIndex = 0;
            btnNewProduct.Text = "Novo";
            btnNewProduct.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNewProduct.UseVisualStyleBackColor = true;
            btnNewProduct.Click += btnNewProduct_Click;
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
            // BarCode
            // 
            BarCode.HeaderText = "Bar Code";
            BarCode.Name = "BarCode";
            BarCode.ReadOnly = true;
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
            // FormListProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
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
        private FontAwesome.Sharp.IconButton btnNewProduct;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnVizualize;
        private FontAwesome.Sharp.IconButton btnSearch;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
    }
}