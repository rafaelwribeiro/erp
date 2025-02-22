namespace erp.desktopApp.Forms.Login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            iconPassword = new FontAwesome.Sharp.IconPictureBox();
            pnlUser = new Panel();
            txtUser = new TextBox();
            iconUser = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            btnClose = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPassword).BeginInit();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 530);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(137, 490);
            label4.Name = "label4";
            label4.Size = new Size(110, 13);
            label4.TabIndex = 4;
            label4.Text = "Rafael William Ribeiro";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 477);
            label3.Name = "label3";
            label3.Size = new Size(90, 13);
            label3.TabIndex = 3;
            label3.Text = "Desenvolvido por";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(133, 210);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 2;
            label2.Text = "RW Gestão";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 183);
            label1.Name = "label1";
            label1.Size = new Size(193, 26);
            label1.TabIndex = 1;
            label1.Text = "Seja bem vindo ao";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(68, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pnlPassword);
            panel1.Controls.Add(pnlUser);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(260, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 530);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8F);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(9, 490);
            label7.Name = "label7";
            label7.Size = new Size(153, 13);
            label7.TabIndex = 7;
            label7.Text = "® Todos os direitos reservados";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8F);
            btnClear.ForeColor = Color.FromArgb(41, 128, 185);
            btnClear.Location = new Point(163, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 35);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpar campos";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(9, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlPassword
            // 
            pnlPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPassword.BackColor = SystemColors.Control;
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Controls.Add(iconPassword);
            pnlPassword.Location = new Point(0, 236);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(490, 45);
            pnlPassword.TabIndex = 4;
            pnlPassword.Click += txtPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.ForeColor = Color.FromArgb(41, 128, 185);
            txtPassword.Location = new Point(46, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(432, 19);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Click += txtPassword_Click;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // iconPassword
            // 
            iconPassword.BackColor = SystemColors.Control;
            iconPassword.ForeColor = Color.FromArgb(41, 128, 185);
            iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPassword.IconColor = Color.FromArgb(41, 128, 185);
            iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPassword.IconSize = 24;
            iconPassword.Location = new Point(16, 10);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new Size(24, 24);
            iconPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPassword.TabIndex = 1;
            iconPassword.TabStop = false;
            iconPassword.Click += txtPassword_Click;
            // 
            // pnlUser
            // 
            pnlUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUser.BackColor = Color.White;
            pnlUser.Controls.Add(txtUser);
            pnlUser.Controls.Add(iconUser);
            pnlUser.Location = new Point(0, 185);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(490, 45);
            pnlUser.TabIndex = 3;
            pnlUser.Click += txtUser_Click;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.FromArgb(41, 128, 185);
            txtUser.Location = new Point(46, 14);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(432, 19);
            txtUser.TabIndex = 1;
            txtUser.Click += txtUser_Click;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.White;
            iconUser.ForeColor = Color.FromArgb(41, 128, 185);
            iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            iconUser.IconColor = Color.FromArgb(41, 128, 185);
            iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUser.IconSize = 24;
            iconUser.Location = new Point(16, 10);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(24, 24);
            iconUser.SizeMode = PictureBoxSizeMode.CenterImage;
            iconUser.TabIndex = 0;
            iconUser.TabStop = false;
            iconUser.Click += txtUser_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft Sans Serif", 16F);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(37, 143);
            label5.Name = "label5";
            label5.Size = new Size(238, 26);
            label5.TabIndex = 2;
            label5.Text = "Logue com seu usuário";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(450, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Shown += FormLogin_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPassword).EndInit();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnClose;
        private Panel pnlUser;
        private Label label5;
        private Panel pnlPassword;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnLogin;
        private Button btnClear;
        private Label label7;
    }
}