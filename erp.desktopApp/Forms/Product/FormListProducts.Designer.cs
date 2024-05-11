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
            panel1 = new Panel();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
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
            gridProducts.Location = new Point(-2, 20);
            gridProducts.MultiSelect = false;
            gridProducts.Name = "gridProducts";
            gridProducts.ReadOnly = true;
            gridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProducts.Size = new Size(800, 429);
            gridProducts.TabIndex = 0;
            gridProducts.DoubleClick += gridProducts_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 19);
            panel1.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridProducts;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
    }
}