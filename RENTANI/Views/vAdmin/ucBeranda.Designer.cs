namespace RentaniApp.Views
{
    partial class ucBeranda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpRingkasan = new TableLayoutPanel();
            pnlCard1 = new Panel();
            lblValAlat = new Label();
            lblKetAlat = new Label();
            pnlCard2 = new Panel();
            lblValSewa = new Label();
            lblKetSewa = new Label();
            pnlCard3 = new Panel();
            lblValIncome = new Label();
            lblKetIncome = new Label();
            lblTitleTabel = new Label();
            dgvPengajuan = new DataGridView();
            lblTitlePopuler = new Label();
            tlpPopuler = new TableLayoutPanel();
            pnlPop1 = new Panel();
            lblPopHarga1 = new Label();
            lblPopKet1 = new Label();
            lblPopNama1 = new Label();
            pnlPop2 = new Panel();
            lblPopHarga2 = new Label();
            lblPopKet2 = new Label();
            lblPopNama2 = new Label();
            pnlPop3 = new Panel();
            lblPopHarga3 = new Label();
            lblPopKet3 = new Label();
            lblPopNama3 = new Label();
            label1 = new Label();
            tlpRingkasan.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengajuan).BeginInit();
            tlpPopuler.SuspendLayout();
            pnlPop1.SuspendLayout();
            pnlPop2.SuspendLayout();
            pnlPop3.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRingkasan
            // 
            tlpRingkasan.ColumnCount = 4;
            tlpRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRingkasan.Controls.Add(pnlCard1, 0, 0);
            tlpRingkasan.Controls.Add(pnlCard2, 1, 0);
            tlpRingkasan.Controls.Add(pnlCard3, 2, 0);
            tlpRingkasan.Location = new Point(309, 146);
            tlpRingkasan.Name = "tlpRingkasan";
            tlpRingkasan.RowCount = 1;
            tlpRingkasan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRingkasan.Size = new Size(980, 110);
            tlpRingkasan.TabIndex = 2;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.BorderStyle = BorderStyle.None;
            pnlCard1.Controls.Add(lblValAlat);
            pnlCard1.Controls.Add(lblKetAlat);
            pnlCard1.Dock = DockStyle.Fill;
            pnlCard1.Location = new Point(8, 8);
            pnlCard1.Margin = new Padding(8);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(229, 94);
            pnlCard1.TabIndex = 0;
            // 
            // lblValAlat
            // 
            lblValAlat.AutoSize = true;
            lblValAlat.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValAlat.ForeColor = Color.FromArgb(31, 41, 55);
            lblValAlat.Location = new Point(20, 12);
            lblValAlat.Name = "lblValAlat";
            lblValAlat.Size = new Size(46, 54);
            lblValAlat.TabIndex = 0;
            lblValAlat.Text = "3";
            // 
            // lblKetAlat
            // 
            lblKetAlat.AutoSize = true;
            lblKetAlat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKetAlat.ForeColor = Color.FromArgb(156, 163, 175);
            lblKetAlat.Location = new Point(20, 62);
            lblKetAlat.Name = "lblKetAlat";
            lblKetAlat.Size = new Size(185, 25);
            lblKetAlat.TabIndex = 1;
            lblKetAlat.Text = "Total Alat / 2 Tersedia";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.BorderStyle = BorderStyle.None;
            pnlCard2.Controls.Add(lblValSewa);
            pnlCard2.Controls.Add(lblKetSewa);
            pnlCard2.Dock = DockStyle.Fill;
            pnlCard2.Location = new Point(253, 8);
            pnlCard2.Margin = new Padding(8);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(229, 94);
            pnlCard2.TabIndex = 1;
            // 
            // lblValSewa
            // 
            lblValSewa.AutoSize = true;
            lblValSewa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValSewa.ForeColor = Color.FromArgb(239, 68, 68);
            lblValSewa.Location = new Point(20, 12);
            lblValSewa.Name = "lblValSewa";
            lblValSewa.Size = new Size(46, 54);
            lblValSewa.TabIndex = 0;
            lblValSewa.Text = "2";
            // 
            // lblKetSewa
            // 
            lblKetSewa.AutoSize = true;
            lblKetSewa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKetSewa.ForeColor = Color.FromArgb(156, 163, 175);
            lblKetSewa.Location = new Point(20, 62);
            lblKetSewa.Name = "lblKetSewa";
            lblKetSewa.Size = new Size(236, 25);
            lblKetSewa.TabIndex = 1;
            lblKetSewa.Text = "Pengajuan Baru / Perlu Verif";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.BorderStyle = BorderStyle.None;
            pnlCard3.Controls.Add(lblValIncome);
            pnlCard3.Controls.Add(lblKetIncome);
            pnlCard3.Dock = DockStyle.Fill;
            pnlCard3.Location = new Point(498, 8);
            pnlCard3.Margin = new Padding(8);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(229, 94);
            pnlCard3.TabIndex = 2;
            // 
            // lblValIncome
            // 
            lblValIncome.AutoSize = true;
            lblValIncome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValIncome.ForeColor = Color.FromArgb(16, 185, 129);
            lblValIncome.Location = new Point(20, 12);
            lblValIncome.Name = "lblValIncome";
            lblValIncome.Size = new Size(180, 54);
            lblValIncome.TabIndex = 0;
            lblValIncome.Text = "Rp 1.300K";
            // 
            // lblKetIncome
            // 
            lblKetIncome.AutoSize = true;
            lblKetIncome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKetIncome.ForeColor = Color.FromArgb(156, 163, 175);
            lblKetIncome.Location = new Point(20, 62);
            lblKetIncome.Name = "lblKetIncome";
            lblKetIncome.Size = new Size(233, 25);
            lblKetIncome.TabIndex = 1;
            lblKetIncome.Text = "Pendapatan / Selesai Bayar";
            // 
            // lblTitleTabel
            // 
            lblTitleTabel.AutoSize = true;
            lblTitleTabel.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTitleTabel.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitleTabel.Location = new Point(309, 275);
            lblTitleTabel.Name = "lblTitleTabel";
            lblTitleTabel.Size = new Size(243, 36);
            lblTitleTabel.TabIndex = 3;
            lblTitleTabel.Text = "Pengajuan Terbaru";
            // 
            // dgvPengajuan
            // 
            dgvPengajuan.BackgroundColor = Color.White;
            dgvPengajuan.BorderStyle = BorderStyle.None;
            dgvPengajuan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPengajuan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(31, 41, 55);
            headerStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(31, 41, 55);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPengajuan.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvPengajuan.ColumnHeadersHeight = 40;
            dgvPengajuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.Font = new Font("Segoe UI", 9.5F);
            rowStyle.ForeColor = Color.FromArgb(55, 65, 81);
            rowStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            rowStyle.SelectionForeColor = Color.FromArgb(29, 78, 216);
            dgvPengajuan.DefaultCellStyle = rowStyle;

            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            altRowStyle.BackColor = Color.FromArgb(249, 250, 251);
            dgvPengajuan.AlternatingRowsDefaultCellStyle = altRowStyle;

            dgvPengajuan.RowHeadersVisible = false;
            dgvPengajuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengajuan.AllowUserToResizeRows = false;
            dgvPengajuan.Location = new Point(315, 320);
            dgvPengajuan.Name = "dgvPengajuan";
            dgvPengajuan.RowTemplate.Height = 35;
            dgvPengajuan.Size = new Size(968, 185);
            dgvPengajuan.TabIndex = 4;
            // 
            // lblTitlePopuler
            // 
            lblTitlePopuler.AutoSize = true;
            lblTitlePopuler.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTitlePopuler.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitlePopuler.Location = new Point(309, 525);
            lblTitlePopuler.Name = "lblTitlePopuler";
            lblTitlePopuler.Size = new Size(311, 36);
            lblTitlePopuler.TabIndex = 5;
            lblTitlePopuler.Text = "Alat Paling Sering Disewa";
            // 
            // tlpPopuler
            // 
            tlpPopuler.ColumnCount = 3;
            tlpPopuler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpPopuler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpPopuler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpPopuler.Controls.Add(pnlPop1, 0, 0);
            tlpPopuler.Controls.Add(pnlPop2, 1, 0);
            tlpPopuler.Controls.Add(pnlPop3, 2, 0);
            tlpPopuler.Location = new Point(309, 570);
            tlpPopuler.Name = "tlpPopuler";
            tlpPopuler.RowCount = 1;
            tlpPopuler.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPopuler.Size = new Size(980, 130);
            tlpPopuler.TabIndex = 6;
            // 
            // pnlPop1
            // 
            pnlPop1.BackColor = Color.White;
            pnlPop1.BorderStyle = BorderStyle.None;
            pnlPop1.Controls.Add(lblPopHarga1);
            pnlPop1.Controls.Add(lblPopKet1);
            pnlPop1.Controls.Add(lblPopNama1);
            pnlPop1.Dock = DockStyle.Fill;
            pnlPop1.Location = new Point(6, 6);
            pnlPop1.Margin = new Padding(6);
            pnlPop1.Name = "pnlPop1";
            pnlPop1.Size = new Size(314, 118);
            pnlPop1.TabIndex = 0;
            // 
            // lblPopNama1
            // 
            lblPopNama1.AutoSize = true;
            lblPopNama1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPopNama1.ForeColor = Color.FromArgb(31, 41, 55);
            lblPopNama1.Location = new Point(18, 15);
            lblPopNama1.Name = "lblPopNama1";
            lblPopNama1.Size = new Size(198, 30);
            lblPopNama1.TabIndex = 0;
            lblPopNama1.Text = "#1 Traktor Kubota";
            // 
            // lblPopKet1
            // 
            lblPopKet1.AutoSize = true;
            lblPopKet1.Font = new Font("Segoe UI", 9F);
            lblPopKet1.ForeColor = Color.FromArgb(107, 114, 128);
            lblPopKet1.Location = new Point(18, 48);
            lblPopKet1.Name = "lblPopKet1";
            lblPopKet1.Size = new Size(121, 25);
            lblPopKet1.TabIndex = 1;
            lblPopKet1.Text = "15 Kali disewa";
            // 
            // lblPopHarga1
            // 
            lblPopHarga1.AutoSize = true;
            lblPopHarga1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPopHarga1.ForeColor = Color.FromArgb(59, 130, 246);
            lblPopHarga1.Location = new Point(18, 78);
            lblPopHarga1.Name = "lblPopHarga1";
            lblPopHarga1.Size = new Size(147, 30);
            lblPopHarga1.TabIndex = 2;
            lblPopHarga1.Text = "Rp 6.000.000";
            // 
            // pnlPop2
            // 
            pnlPop2.BackColor = Color.White;
            pnlPop2.BorderStyle = BorderStyle.None;
            pnlPop2.Controls.Add(lblPopHarga2);
            pnlPop2.Controls.Add(lblPopKet2);
            pnlPop2.Controls.Add(lblPopNama2);
            pnlPop2.Dock = DockStyle.Fill;
            pnlPop2.Location = new Point(332, 6);
            pnlPop2.Margin = new Padding(6);
            pnlPop2.Name = "pnlPop2";
            pnlPop2.Size = new Size(314, 118);
            pnlPop2.TabIndex = 1;
            // 
            // lblPopNama2
            // 
            lblPopNama2.AutoSize = true;
            lblPopNama2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPopNama2.ForeColor = Color.FromArgb(31, 41, 55);
            lblPopNama2.Location = new Point(18, 15);
            lblPopNama2.Name = "lblPopNama2";
            lblPopNama2.Size = new Size(198, 30);
            lblPopNama2.Text = "#2 Traktor Tangan";
            // 
            // lblPopKet2
            // 
            lblPopKet2.AutoSize = true;
            lblPopKet2.Font = new Font("Segoe UI", 9F);
            lblPopKet2.ForeColor = Color.FromArgb(107, 114, 128);
            lblPopKet2.Location = new Point(18, 48);
            lblPopKet2.Name = "lblPopKet2";
            lblPopKet2.Size = new Size(121, 25);
            lblPopKet2.TabIndex = 1;
            lblPopKet2.Text = "12 Kali disewa";
            // 
            // lblPopHarga2
            // 
            lblPopHarga2.AutoSize = true;
            lblPopHarga2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPopHarga2.ForeColor = Color.FromArgb(59, 130, 246);
            lblPopHarga2.Location = new Point(18, 78);
            lblPopHarga2.Name = "lblPopHarga2";
            lblPopHarga2.Size = new Size(147, 30);
            lblPopHarga2.TabIndex = 2;
            lblPopHarga2.Text = "Rp 3.000.000";
            // 
            // pnlPop3
            // 
            pnlPop3.BackColor = Color.White;
            pnlPop3.BorderStyle = BorderStyle.None;
            pnlPop3.Controls.Add(lblPopHarga3);
            pnlPop3.Controls.Add(lblPopKet3);
            pnlPop3.Controls.Add(lblPopNama3);
            pnlPop3.Dock = DockStyle.Fill;
            pnlPop3.Location = new Point(658, 6);
            pnlPop3.Margin = new Padding(6);
            pnlPop3.Name = "pnlPop3";
            pnlPop3.Size = new Size(316, 118);
            pnlPop3.TabIndex = 2;
            // 
            // lblPopNama3
            // 
            lblPopNama3.AutoSize = true;
            lblPopNama3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPopNama3.ForeColor = Color.FromArgb(31, 41, 55);
            lblPopNama3.Location = new Point(18, 15);
            lblPopNama3.Name = "lblPopNama3";
            lblPopNama3.Size = new Size(220, 30);
            lblPopNama3.TabIndex = 0;
            lblPopNama3.Text = "#3 Hand Sprayer 14L";
            // 
            // lblPopKet3
            // 
            lblPopKet3.AutoSize = true;
            lblPopKet3.Font = new Font("Segoe UI", 9F);
            lblPopKet3.ForeColor = Color.FromArgb(107, 114, 128);
            lblPopKet3.Location = new Point(18, 48);
            lblPopKet3.Name = "lblPopKet3";
            lblPopKet3.Size = new Size(111, 25);
            lblPopKet3.TabIndex = 1;
            lblPopKet3.Text = "9 Kali disewa";
            // 
            // lblPopHarga3
            // 
            lblPopHarga3.AutoSize = true;
            lblPopHarga3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPopHarga3.ForeColor = Color.FromArgb(59, 130, 246);
            lblPopHarga3.Location = new Point(18, 78);
            lblPopHarga3.Name = "lblPopHarga3";
            lblPopHarga3.Size = new Size(128, 30);
            lblPopHarga3.TabIndex = 2;
            lblPopHarga3.Text = "Rp 315.000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(309, 25);
            label1.Name = "label1";
            label1.Size = new Size(158, 48);
            label1.TabIndex = 7;
            label1.Text = "Dashboard Overview";
            // 
            // ucBeranda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(label1);
            Controls.Add(tlpPopuler);
            Controls.Add(lblTitlePopuler);
            Controls.Add(dgvPengajuan);
            Controls.Add(lblTitleTabel);
            Controls.Add(tlpRingkasan);
            Name = "ucBeranda";
            Size = new Size(1312, 720);
            tlpRingkasan.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengajuan).EndInit();
            tlpPopuler.ResumeLayout(false);
            pnlPop1.ResumeLayout(false);
            pnlPop1.PerformLayout();
            pnlPop2.ResumeLayout(false);
            pnlPop2.PerformLayout();
            pnlPop3.ResumeLayout(false);
            pnlPop3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tlpRingkasan;
        private Panel pnlCard1;
        private Label lblValAlat;
        private Label lblKetAlat;
        private Panel pnlCard2;
        private Label lblValSewa;
        private Label lblKetSewa;
        private Panel pnlCard3;
        private Label lblValIncome;
        private Label lblKetIncome;
        private Label lblTitleTabel;
        private DataGridView dgvPengajuan;
        private Label lblTitlePopuler;
        private TableLayoutPanel tlpPopuler;
        private Panel pnlPop1;
        private Label lblPopHarga1;
        private Label lblPopKet1;
        private Label lblPopNama1;
        private Panel pnlPop2;
        private Label lblPopHarga2;
        private Label lblPopKet2;
        private Label lblPopNama2;
        private Panel pnlPop3;
        private Label lblPopHarga3;
        private Label lblPopKet3;
        private Label lblPopNama3;
        private Label label1;
    }
}