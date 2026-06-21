namespace RentaniApp.Views.vPenyewa
{
    partial class ucPembayaranPenyewa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Text = new Label();
            dgvPembayaran = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlPerluBayar = new Guna.UI2.WinForms.Guna2Panel();
            lblPerluBayar = new Label();
            lblTitlePerlu = new Label();
            pnlTotalBerhasil = new Guna.UI2.WinForms.Guna2Panel();
            lblTotalBerhasilBayar = new Label();
            lblTitleBerhasil = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).BeginInit();
            pnlPerluBayar.SuspendLayout();
            pnlTotalBerhasil.SuspendLayout();
            SuspendLayout();

            Text.AutoSize = true;
            Text.BackColor = Color.Transparent;
            Text.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text.Location = new Point(28, 23);
            Text.Name = "Text";
            Text.Size = new Size(459, 38);
            Text.TabIndex = 1;
            Text.Text = "Tagihan dan Riwayat Pembayaran";

            dgvPembayaran.AllowUserToAddRows = false;
            dgvPembayaran.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dgvPembayaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPembayaran.ColumnHeadersHeight = 35;
            dgvPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPembayaran.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPembayaran.GridColor = Color.FromArgb(231, 229, 255);
            dgvPembayaran.Location = new Point(28, 190);
            dgvPembayaran.Name = "dgvPembayaran";
            dgvPembayaran.ReadOnly = true;
            dgvPembayaran.RowHeadersVisible = false;
            dgvPembayaran.RowHeadersWidth = 62;
            dgvPembayaran.RowTemplate.Height = 25;
            dgvPembayaran.Size = new Size(914, 450);
            dgvPembayaran.TabIndex = 2;
            dgvPembayaran.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPembayaran.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(46, 204, 113);
            dgvPembayaran.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPembayaran.ThemeStyle.HeaderStyle.Height = 35;
            dgvPembayaran.ThemeStyle.ReadOnly = true;
            dgvPembayaran.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPembayaran.ThemeStyle.RowsStyle.Height = 25;
            dgvPembayaran.CellContentClick += dgvPembayaran_CellContentClick;

            pnlPerluBayar.BackColor = Color.White;
            pnlPerluBayar.BorderRadius = 10;
            pnlPerluBayar.Controls.Add(lblPerluBayar);
            pnlPerluBayar.Controls.Add(lblTitlePerlu);
            pnlPerluBayar.CustomizableEdges = customizableEdges1;
            pnlPerluBayar.Location = new Point(28, 80);
            pnlPerluBayar.Name = "pnlPerluBayar";
            pnlPerluBayar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlPerluBayar.Size = new Size(440, 85);
            pnlPerluBayar.TabIndex = 3;

            lblPerluBayar.AutoSize = true;
            lblPerluBayar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPerluBayar.ForeColor = Color.Red;
            lblPerluBayar.Location = new Point(15, 40);
            lblPerluBayar.Name = "lblPerluBayar";
            lblPerluBayar.Size = new Size(140, 32);
            lblPerluBayar.TabIndex = 0;
            lblPerluBayar.Text = "0 Transaksi";

            lblTitlePerlu.AutoSize = true;
            lblTitlePerlu.Font = new Font("Segoe UI", 9F);
            lblTitlePerlu.ForeColor = Color.Gray;
            lblTitlePerlu.Location = new Point(15, 15);
            lblTitlePerlu.Name = "lblTitlePerlu";
            lblTitlePerlu.Size = new Size(201, 25);
            lblTitlePerlu.TabIndex = 1;
            lblTitlePerlu.Text = "Menunggu Pembayaran";

            pnlTotalBerhasil.BackColor = Color.White;
            pnlTotalBerhasil.BorderRadius = 10;
            pnlTotalBerhasil.Controls.Add(lblTotalBerhasilBayar);
            pnlTotalBerhasil.Controls.Add(lblTitleBerhasil);
            pnlTotalBerhasil.CustomizableEdges = customizableEdges3;
            pnlTotalBerhasil.Location = new Point(502, 80);
            pnlTotalBerhasil.Name = "pnlTotalBerhasil";
            pnlTotalBerhasil.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlTotalBerhasil.Size = new Size(440, 85);
            pnlTotalBerhasil.TabIndex = 4;

            lblTotalBerhasilBayar.AutoSize = true;
            lblTotalBerhasilBayar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalBerhasilBayar.ForeColor = Color.Green;
            lblTotalBerhasilBayar.Location = new Point(15, 40);
            lblTotalBerhasilBayar.Name = "lblTotalBerhasilBayar";
            lblTotalBerhasilBayar.Size = new Size(66, 32);
            lblTotalBerhasilBayar.TabIndex = 0;
            lblTotalBerhasilBayar.Text = "Rp 0";

            lblTitleBerhasil.AutoSize = true;
            lblTitleBerhasil.Font = new Font("Segoe UI", 9F);
            lblTitleBerhasil.ForeColor = Color.Gray;
            lblTitleBerhasil.Location = new Point(15, 15);
            lblTitleBerhasil.Name = "lblTitleBerhasil";
            lblTitleBerhasil.Size = new Size(180, 25);
            lblTitleBerhasil.TabIndex = 1;
            lblTitleBerhasil.Text = "Total Berhasil Dibayar";

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlTotalBerhasil);
            Controls.Add(pnlPerluBayar);
            Controls.Add(dgvPembayaran);
            Controls.Add(Text);
            Name = "ucPembayaranPenyewa";
            Size = new Size(970, 667);
            Load += ucPembayaranPenyewa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).EndInit();
            pnlPerluBayar.ResumeLayout(false);
            pnlPerluBayar.PerformLayout();
            pnlTotalBerhasil.ResumeLayout(false);
            pnlTotalBerhasil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Text;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPembayaran;
        private Guna.UI2.WinForms.Guna2Panel pnlPerluBayar;
        private System.Windows.Forms.Label lblPerluBayar;
        private System.Windows.Forms.Label lblTitlePerlu;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalBerhasil;
        private System.Windows.Forms.Label lblTotalBerhasilBayar;
        private System.Windows.Forms.Label lblTitleBerhasil;
    }
}