namespace erp.desktopApp.Forms.Order
{
    partial class FormListOrder
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
            panel1 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnVizualize = new FontAwesome.Sharp.IconButton();
            btnRemove = new FontAwesome.Sharp.IconButton();
            btnNewProduct = new FontAwesome.Sharp.IconButton();
            gridOrders = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOrders).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
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
            // 
            // gridOrders
            // 
            gridOrders.AllowUserToAddRows = false;
            gridOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            gridOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridOrders.BackgroundColor = Color.Gainsboro;
            gridOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrders.Columns.AddRange(new DataGridViewColumn[] { colId, Customer, Discount, Total });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridOrders.DefaultCellStyle = dataGridViewCellStyle3;
            gridOrders.GridColor = Color.Gainsboro;
            gridOrders.Location = new Point(-1, 45);
            gridOrders.MultiSelect = false;
            gridOrders.Name = "gridOrders";
            gridOrders.ReadOnly = true;
            gridOrders.RowHeadersVisible = false;
            gridOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOrders.Size = new Size(800, 405);
            gridOrders.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Resizable = DataGridViewTriState.False;
            // 
            // Customer
            // 
            Customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Resizable = DataGridViewTriState.False;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Resizable = DataGridViewTriState.False;
            // 
            // FormListOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gridOrders);
            Name = "FormListOrder";
            Text = "FormListOrder";
            Load += FormListOrder_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnVizualize;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnNewProduct;
        private DataGridView gridOrders;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Total;
    }
}