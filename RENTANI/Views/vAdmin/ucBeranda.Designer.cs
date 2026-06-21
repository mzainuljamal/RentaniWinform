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
            pnlCard4 = new Panel();
            lblValRating = new Label();
            lblKetRating = new Label();
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
            pnlPop3 = new Panel();
            lblPopHarga3 = new Label();
            lblPopKet3 = new Label();
            lblPopNama3 = new Label();
            label1 = new Label();
            tlpRingkasan.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
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
            tlpRingkasan.Controls.Add(pnlCard4, 3, 0);
            tlpRingkasan.Location = new Point(309, 146);
            tlpRingkasan.Name = "tlpRingkasan";
            tlpRingkasan.RowCount = 1;
            tlpRingkasan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRingkasan.Size = new Size(980, 100);
            tlpRingkasan.TabIndex = 2;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(lblValAlat);
            pnlCard1.Controls.Add(lblKetAlat);
            pnlCard1.Dock = DockStyle.Fill;
            pnlCard1.Location = new Point(5, 5);
            pnlCard1.Margin = new Padding(5);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(235, 90);
            pnlCard1.TabIndex = 0;
            // 
            // lblValAlat
            // 
            lblValAlat.AutoSize = true;
            lblValAlat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValAlat.ForeColor = Color.FromArgb(31, 41, 55);
            lblValAlat.Location = new Point(15, 10);
            lblValAlat.Name = "lblValAlat";
            lblValAlat.Size = new Size(38, 45);
            lblValAlat.TabIndex = 0;
            lblValAlat.Text = "3";
            // 
            // lblKetAlat
            // 
            lblKetAlat.AutoSize = true;
            lblKetAlat.Font = new Font("Segoe UI", 8.5F);
            lblKetAlat.ForeColor = Color.FromArgb(107, 114, 128);
            lblKetAlat.Location = new Point(15, 48);
            lblKetAlat.Name = "lblKetAlat";
            lblKetAlat.Size = new Size(173, 23);
            lblKetAlat.TabIndex = 1;
            lblKetAlat.Text = "Total Alat / 2 Tersedia";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(lblValSewa);
            pnlCard2.Controls.Add(lblKetSewa);
            pnlCard2.Dock = DockStyle.Fill;
            pnlCard2.Location = new Point(250, 5);
            pnlCard2.Margin = new Padding(5);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(235, 90);
            pnlCard2.TabIndex = 1;
            // 
            // lblValSewa
            // 
            lblValSewa.AutoSize = true;
            lblValSewa.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValSewa.ForeColor = Color.OrangeRed;
            lblValSewa.Location = new Point(15, 10);
            lblValSewa.Name = "lblValSewa";
            lblValSewa.Size = new Size(38, 45);
            lblValSewa.TabIndex = 0;
            lblValSewa.Text = "2";
            // 
            // lblKetSewa
            // 
            lblKetSewa.AutoSize = true;
            lblKetSewa.Font = new Font("Segoe UI", 8.5F);
            lblKetSewa.ForeColor = Color.FromArgb(107, 114, 128);
            lblKetSewa.Location = new Point(15, 48);
            lblKetSewa.Name = "lblKetSewa";
            lblKetSewa.Size = new Size(224, 23);
            lblKetSewa.TabIndex = 1;
            lblKetSewa.Text = "Pengajuan Baru / Perlu Verif";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.BorderStyle = BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(lblValIncome);
            pnlCard3.Controls.Add(lblKetIncome);
            pnlCard3.Dock = DockStyle.Fill;
            pnlCard3.Location = new Point(495, 5);
            pnlCard3.Margin = new Padding(5);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(235, 90);
            pnlCard3.TabIndex = 2;
            // 
            // lblValIncome
            // 
            lblValIncome.AutoSize = true;
            lblValIncome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValIncome.ForeColor = Color.ForestGreen;
            lblValIncome.Location = new Point(15, 10);
            lblValIncome.Name = "lblValIncome";
            lblValIncome.Size = new Size(172, 45);
            lblValIncome.TabIndex = 0;
            lblValIncome.Text = "Rp 1.300K";
            // 
            // lblKetIncome
            // 
            lblKetIncome.AutoSize = true;
            lblKetIncome.Font = new Font("Segoe UI", 8.5F);
            lblKetIncome.ForeColor = Color.FromArgb(107, 114, 128);
            lblKetIncome.Location = new Point(15, 48);
            lblKetIncome.Name = "lblKetIncome";
            lblKetIncome.Size = new Size(216, 23);
            lblKetIncome.TabIndex = 1;
            lblKetIncome.Text = "Pendapatan / Selesai Bayar";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.White;
            pnlCard4.BorderStyle = BorderStyle.FixedSingle;
            pnlCard4.Controls.Add(lblValRating);
            pnlCard4.Controls.Add(lblKetRating);
            pnlCard4.Dock = DockStyle.Fill;
            pnlCard4.Location = new Point(740, 5);
            pnlCard4.Margin = new Padding(5);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(235, 90);
            pnlCard4.TabIndex = 3;
            // 
            // lblValRating
            // 
            lblValRating.AutoSize = true;
            lblValRating.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValRating.ForeColor = Color.BlueViolet;
            lblValRating.Location = new Point(15, 10);
            lblValRating.Name = "lblValRating";
            lblValRating.Size = new Size(102, 45);
            lblValRating.TabIndex = 0;
            lblValRating.Text = "4.7 ★";
            // 
            // lblKetRating
            // 
            lblKetRating.AutoSize = true;
            lblKetRating.Font = new Font("Segoe UI", 8.5F);
            lblKetRating.ForeColor = Color.FromArgb(107, 114, 128);
            lblKetRating.Location = new Point(15, 48);
            lblKetRating.Name = "lblKetRating";
            lblKetRating.Size = new Size(177, 23);
            lblKetRating.TabIndex = 1;
            lblKetRating.Text = "Rating / Dari 3 Ulasan";
            // 
            // lblTitleTabel
            // 
            lblTitleTabel.AutoSize = true;
            lblTitleTabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitleTabel.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitleTabel.Location = new Point(309, 249);
            lblTitleTabel.Name = "lblTitleTabel";
            lblTitleTabel.Size = new Size(218, 32);
            lblTitleTabel.TabIndex = 3;
            lblTitleTabel.Text = "Pengajuan Terbaru";
            // 
            // dgvPengajuan
            // 
            dgvPengajuan.BackgroundColor = Color.White;
            dgvPengajuan.BorderStyle = BorderStyle.None;
            dgvPengajuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengajuan.Location = new Point(299, 284);
            dgvPengajuan.Name = "dgvPengajuan";
            dgvPengajuan.RowHeadersWidth = 51;
            dgvPengajuan.Size = new Size(980, 200);
            dgvPengajuan.TabIndex = 4;
            // 
            // lblTitlePopuler
            // 
            lblTitlePopuler.AutoSize = true;
            lblTitlePopuler.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitlePopuler.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitlePopuler.Location = new Point(304, 487);
            lblTitlePopuler.Name = "lblTitlePopuler";
            lblTitlePopuler.Size = new Size(291, 32);
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
            tlpPopuler.Location = new Point(293, 522);
            tlpPopuler.Name = "tlpPopuler";
            tlpPopuler.RowCount = 1;
            tlpPopuler.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPopuler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPopuler.Size = new Size(980, 140);
            tlpPopuler.TabIndex = 6;
            // 
            // pnlPop1
            // 
            pnlPop1.BackColor = Color.White;
            pnlPop1.BorderStyle = BorderStyle.FixedSingle;
            pnlPop1.Controls.Add(lblPopHarga1);
            pnlPop1.Controls.Add(lblPopKet1);
            pnlPop1.Controls.Add(lblPopNama1);
            pnlPop1.Dock = DockStyle.Fill;
            pnlPop1.Location = new Point(5, 5);
            pnlPop1.Margin = new Padding(5);
            pnlPop1.Name = "pnlPop1";
            pnlPop1.Size = new Size(316, 130);
            pnlPop1.TabIndex = 0;
            // 
            // lblPopHarga1
            // 
            lblPopHarga1.AutoSize = true;
            lblPopHarga1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPopHarga1.ForeColor = Color.ForestGreen;
            lblPopHarga1.Location = new Point(15, 85);
            lblPopHarga1.Name = "lblPopHarga1";
            lblPopHarga1.Size = new Size(150, 30);
            lblPopHarga1.TabIndex = 2;
            lblPopHarga1.Text = "Rp 6.000.000";
            // 
            // lblPopKet1
            // 
            lblPopKet1.AutoSize = true;
            lblPopKet1.ForeColor = Color.Gray;
            lblPopKet1.Location = new Point(15, 48);
            lblPopKet1.Name = "lblPopKet1";
            lblPopKet1.Size = new Size(123, 25);
            lblPopKet1.TabIndex = 1;
            lblPopKet1.Text = "15 Kali disewa";
            // 
            // lblPopNama1
            // 
            lblPopNama1.AutoSize = true;
            lblPopNama1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblPopNama1.Location = new Point(15, 15);
            lblPopNama1.Name = "lblPopNama1";
            lblPopNama1.Size = new Size(184, 30);
            lblPopNama1.TabIndex = 0;
            lblPopNama1.Text = "#1 Traktor Kubota";
            // 
            // pnlPop2
            // 
            pnlPop2.BackColor = Color.White;
            pnlPop2.BorderStyle = BorderStyle.FixedSingle;
            pnlPop2.Controls.Add(lblPopHarga2);
            pnlPop2.Controls.Add(lblPopKet2);
            pnlPop2.Dock = DockStyle.Fill;
            pnlPop2.Location = new Point(331, 5);
            pnlPop2.Margin = new Padding(5);
            pnlPop2.Name = "pnlPop2";
            pnlPop2.Size = new Size(316, 130);
            pnlPop2.TabIndex = 1;
            // 
            // lblPopHarga2
            // 
            lblPopHarga2.AutoSize = true;
            lblPopHarga2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPopHarga2.ForeColor = Color.ForestGreen;
            lblPopHarga2.Location = new Point(15, 85);
            lblPopHarga2.Name = "lblPopHarga2";
            lblPopHarga2.Size = new Size(150, 30);
            lblPopHarga2.TabIndex = 2;
            lblPopHarga2.Text = "Rp 3.000.000";
            // 
            // lblPopKet2
            // 
            lblPopKet2.AutoSize = true;
            lblPopKet2.ForeColor = Color.Gray;
            lblPopKet2.Location = new Point(15, 48);
            lblPopKet2.Name = "lblPopKet2";
            lblPopKet2.Size = new Size(123, 25);
            lblPopKet2.TabIndex = 1;
            lblPopKet2.Text = "12 Kali disewa";
            // 
            // pnlPop3
            // 
            pnlPop3.BackColor = Color.White;
            pnlPop3.BorderStyle = BorderStyle.FixedSingle;
            pnlPop3.Controls.Add(lblPopHarga3);
            pnlPop3.Controls.Add(lblPopKet3);
            pnlPop3.Controls.Add(lblPopNama3);
            pnlPop3.Dock = DockStyle.Fill;
            pnlPop3.Location = new Point(657, 5);
            pnlPop3.Margin = new Padding(5);
            pnlPop3.Name = "pnlPop3";
            pnlPop3.Size = new Size(318, 130);
            pnlPop3.TabIndex = 2;
            // 
            // lblPopHarga3
            // 
            lblPopHarga3.AutoSize = true;
            lblPopHarga3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPopHarga3.ForeColor = Color.ForestGreen;
            lblPopHarga3.Location = new Point(15, 85);
            lblPopHarga3.Name = "lblPopHarga3";
            lblPopHarga3.Size = new Size(131, 30);
            lblPopHarga3.TabIndex = 2;
            lblPopHarga3.Text = "Rp 315.000";
            // 
            // lblPopKet3
            // 
            lblPopKet3.AutoSize = true;
            lblPopKet3.ForeColor = Color.Gray;
            lblPopKet3.Location = new Point(15, 48);
            lblPopKet3.Name = "lblPopKet3";
            lblPopKet3.Size = new Size(113, 25);
            lblPopKet3.TabIndex = 1;
            lblPopKet3.Text = "9 Kali disewa";
            // 
            // lblPopNama3
            // 
            lblPopNama3.AutoSize = true;
            lblPopNama3.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblPopNama3.Location = new Point(15, 15);
            lblPopNama3.Name = "lblPopNama3";
            lblPopNama3.Size = new Size(209, 30);
            lblPopNama3.TabIndex = 0;
            lblPopNama3.Text = "#3 Hand Sprayer 14L";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 7;
            label1.Text = "Beranda";
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
            Size = new Size(1312, 680);
            tlpRingkasan.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
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
        private Panel pnlCard4;
        private Label lblValRating;
        private Label lblKetRating;
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