namespace RentaniApp.Views.vPenyewa
{
    partial class ucPenyewaanSaya
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
            lblJudul = new Label();
            lblSubJudul = new Label();
            dgvPenyewaanSaya = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlInfo = new Guna.UI2.WinForms.Guna2Panel();
            lblInfoText = new Label();
            lblInfoIcon = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPenyewaanSaya).BeginInit();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(33, 37, 41);
            lblJudul.Location = new Point(30, 25);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(440, 48);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat Penyewaan Saya";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 9.5F);
            lblSubJudul.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubJudul.Location = new Point(32, 75);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(624, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Berikut adalah data pelacakan dan status alat pertanian yang Anda sewa.";
            // 
            // dgvPenyewaanSaya
            // 
            dgvPenyewaanSaya.AllowUserToAddRows = false;
            dgvPenyewaanSaya.AllowUserToDeleteRows = false;
            dgvPenyewaanSaya.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPenyewaanSaya.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPenyewaanSaya.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPenyewaanSaya.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPenyewaanSaya.ColumnHeadersHeight = 45;
            dgvPenyewaanSaya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPenyewaanSaya.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPenyewaanSaya.GridColor = Color.FromArgb(242, 244, 246);
            dgvPenyewaanSaya.Location = new Point(35, 130);
            dgvPenyewaanSaya.Name = "dgvPenyewaanSaya";
            dgvPenyewaanSaya.ReadOnly = true;
            dgvPenyewaanSaya.RowHeadersVisible = false;
            dgvPenyewaanSaya.RowHeadersWidth = 62;
            dgvPenyewaanSaya.RowTemplate.Height = 50;
            dgvPenyewaanSaya.Size = new Size(900, 410);
            dgvPenyewaanSaya.TabIndex = 2;
            dgvPenyewaanSaya.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPenyewaanSaya.ThemeStyle.GridColor = Color.FromArgb(242, 244, 246);
            dgvPenyewaanSaya.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvPenyewaanSaya.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dgvPenyewaanSaya.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(73, 80, 87);
            dgvPenyewaanSaya.ThemeStyle.HeaderStyle.Height = 45;
            dgvPenyewaanSaya.ThemeStyle.ReadOnly = true;
            dgvPenyewaanSaya.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPenyewaanSaya.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvPenyewaanSaya.ThemeStyle.RowsStyle.Height = 50;
            dgvPenyewaanSaya.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(233, 236, 239);
            dgvPenyewaanSaya.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dgvPenyewaanSaya.CellContentClick += dgvPenyewaanSaya_CellContentClick;
            // 
            // pnlInfo
            // 
            pnlInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInfo.BorderColor = Color.FromArgb(204, 229, 255);
            pnlInfo.BorderRadius = 8;
            pnlInfo.BorderThickness = 1;
            pnlInfo.Controls.Add(lblInfoText);
            pnlInfo.Controls.Add(lblInfoIcon);
            pnlInfo.CustomizableEdges = customizableEdges1;
            pnlInfo.FillColor = Color.FromArgb(230, 242, 255);
            pnlInfo.Location = new Point(35, 565);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlInfo.Size = new Size(932, 65);
            pnlInfo.TabIndex = 3;
            // 
            // lblInfoText
            // 
            lblInfoText.AutoSize = true;
            lblInfoText.BackColor = Color.Transparent;
            lblInfoText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblInfoText.ForeColor = Color.FromArgb(0, 64, 128);
            lblInfoText.Location = new Point(45, 20);
            lblInfoText.Name = "lblInfoText";
            lblInfoText.Size = new Size(885, 25);
            lblInfoText.TabIndex = 1;
            lblInfoText.Text = "Aksi pembatalan sewa hanya berlaku untuk transaksi dengan status \"Menunggu\" verifikasi pemilik rental.";
            // 
            // lblInfoIcon
            // 
            lblInfoIcon.AutoSize = true;
            lblInfoIcon.BackColor = Color.Transparent;
            lblInfoIcon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfoIcon.ForeColor = Color.FromArgb(0, 102, 204);
            lblInfoIcon.Location = new Point(15, 18);
            lblInfoIcon.Name = "lblInfoIcon";
            lblInfoIcon.Size = new Size(40, 28);
            lblInfoIcon.TabIndex = 0;
            lblInfoIcon.Text = "ℹ";
            // 
            // ucPenyewaanSaya
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlInfo);
            Controls.Add(dgvPenyewaanSaya);
            Controls.Add(lblSubJudul);
            Controls.Add(lblJudul);
            Name = "ucPenyewaanSaya";
            Size = new Size(970, 667);
            Load += ucPenyewaanSaya_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPenyewaanSaya).EndInit();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPenyewaanSaya;
        private Guna.UI2.WinForms.Guna2Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Label lblInfoIcon;
    }
}