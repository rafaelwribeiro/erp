namespace erp.desktopApp
{
    partial class FormEditOrder
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
            panel1 = new Panel();
            pnlItens = new FlowLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            lblConsumidor = new Label();
            panel5 = new Panel();
            lblId = new Label();
            label1 = new Label();
            lblStatus = new Label();
            lblStatusDescription = new Label();
            lblTotal = new Label();
            lblTotalDescription = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlItens);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(488, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 561);
            panel1.TabIndex = 1;
            // 
            // pnlItens
            // 
            pnlItens.AutoScroll = true;
            pnlItens.Dock = DockStyle.Fill;
            pnlItens.FlowDirection = FlowDirection.TopDown;
            pnlItens.Location = new Point(0, 58);
            pnlItens.Name = "pnlItens";
            pnlItens.Size = new Size(496, 438);
            pnlItens.TabIndex = 2;
            pnlItens.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 496);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 65);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(496, 65);
            button1.TabIndex = 0;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblConsumidor);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 58);
            panel2.TabIndex = 0;
            // 
            // lblConsumidor
            // 
            lblConsumidor.AutoSize = true;
            lblConsumidor.Cursor = Cursors.Hand;
            lblConsumidor.Location = new Point(6, 23);
            lblConsumidor.Name = "lblConsumidor";
            lblConsumidor.Size = new Size(73, 15);
            lblConsumidor.TabIndex = 0;
            lblConsumidor.Text = "Consumidor";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblId);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(lblStatus);
            panel5.Controls.Add(lblStatusDescription);
            panel5.Controls.Add(lblTotal);
            panel5.Controls.Add(lblTotalDescription);
            panel5.Controls.Add(textBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(488, 561);
            panel5.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 20F);
            lblId.Location = new Point(121, 441);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 37);
            lblId.TabIndex = 6;
            lblId.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 441);
            label1.Name = "label1";
            label1.Size = new Size(50, 37);
            label1.TabIndex = 5;
            label1.Text = "Id:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 20F);
            lblStatus.Location = new Point(121, 478);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 37);
            lblStatus.TabIndex = 4;
            lblStatus.Text = ". . .";
            // 
            // lblStatusDescription
            // 
            lblStatusDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatusDescription.AutoSize = true;
            lblStatusDescription.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStatusDescription.Location = new Point(12, 478);
            lblStatusDescription.Name = "lblStatusDescription";
            lblStatusDescription.Size = new Size(103, 37);
            lblStatusDescription.TabIndex = 3;
            lblStatusDescription.Text = "Status:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 20F);
            lblTotal.Location = new Point(121, 515);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 37);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "R$ 0,00";
            // 
            // lblTotalDescription
            // 
            lblTotalDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalDescription.AutoSize = true;
            lblTotalDescription.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalDescription.Location = new Point(12, 515);
            lblTotalDescription.Name = "lblTotalDescription";
            lblTotalDescription.Size = new Size(96, 37);
            lblTotalDescription.TabIndex = 1;
            lblTotalDescription.Text = "Total: ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 43);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // FormEditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 600);
            Name = "FormEditOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEditOrder";
            Shown += FormEditOrder_Shown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lblConsumidor;
        private Panel panel3;
        private Panel panel5;
        private TextBox textBox1;
        private Button button1;
        private FlowLayoutPanel pnlItens;
        private Label lblTotalDescription;
        private Label lblTotal;
        private Label lblStatusDescription;
        private Label lblStatus;
        private Label label1;
        private Label lblId;
    }
}