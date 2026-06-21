namespace RentaniApp.Views.vPenyewa
{
    partial class vBayarSewa
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            btnBatal = new Button();
            btnKonfirmasiBayar = new Button();
            lblBuktiTransaksi = new Label();
            lblUploadBukti = new Label();
            pnlUploadBukti = new Panel();
            lblNamaFileBukti = new Label();
            pnlRekening = new Panel();
            lblRekeningInfo = new Label();
            lblTransferKe = new Label();
            lblPilihMetode = new Label();
            cmbMetodeBayar = new ComboBox();
            lblMetodePembayaran = new Label();
            pnlTotalBayar = new Panel();
            lblTotalHarga = new Label();
            lblTextTotal = new Label();
            pnlTagihanCard = new Panel();
            lblPeriode = new Label();
            lblNamaAlat = new Label();
            lblDetailTagihan = new Label();
            btnClose = new Button();
            lblHeader = new Label();
            pnlMain.SuspendLayout();
            pnlUploadBukti.SuspendLayout();
            pnlRekening.SuspendLayout();
            pnlTotalBayar.SuspendLayout();
            pnlTagihanCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btnBatal);
            pnlMain.Controls.Add(btnKonfirmasiBayar);
            pnlMain.Controls.Add(lblBuktiTransaksi);
            pnlMain.Controls.Add(lblUploadBukti);
            pnlMain.Controls.Add(pnlUploadBukti);
            pnlMain.Controls.Add(pnlRekening);
            pnlMain.Controls.Add(lblPilihMetode);
            pnlMain.Controls.Add(cmbMetodeBayar);
            pnlMain.Controls.Add(lblMetodePembayaran);
            pnlMain.Controls.Add(pnlTotalBayar);
            pnlMain.Controls.Add(pnlTagihanCard);
            pnlMain.Controls.Add(lblDetailTagihan);
            pnlMain.Controls.Add(btnClose);
            pnlMain.Controls.Add(lblHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 4, 4, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(650, 956);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderColor = Color.FromArgb(229, 231, 235);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBatal.ForeColor = Color.FromArgb(75, 85, 99);
            btnBatal.Location = new Point(38, 869);
            btnBatal.Margin = new Padding(4, 4, 4, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(269, 56);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnKonfirmasiBayar
            // 
            btnKonfirmasiBayar.BackColor = Color.FromArgb(29, 78, 216);
            btnKonfirmasiBayar.Cursor = Cursors.Hand;
            btnKonfirmasiBayar.FlatAppearance.BorderSize = 0;
            btnKonfirmasiBayar.FlatStyle = FlatStyle.Flat;
            btnKonfirmasiBayar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnKonfirmasiBayar.ForeColor = Color.White;
            btnKonfirmasiBayar.Location = new Point(344, 869);
            btnKonfirmasiBayar.Margin = new Padding(4, 4, 4, 4);
            btnKonfirmasiBayar.Name = "btnKonfirmasiBayar";
            btnKonfirmasiBayar.Size = new Size(269, 56);
            btnKonfirmasiBayar.TabIndex = 13;
            btnKonfirmasiBayar.Text = "Konfirmasi Bayar";
            btnKonfirmasiBayar.UseVisualStyleBackColor = false;
            btnKonfirmasiBayar.Click += btnKonfirmasiBayar_Click;
            // 
            // lblBuktiTransaksi
            // 
            lblBuktiTransaksi.AutoSize = true;
            lblBuktiTransaksi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblBuktiTransaksi.ForeColor = Color.FromArgb(156, 163, 175);
            lblBuktiTransaksi.Location = new Point(38, 694);
            lblBuktiTransaksi.Margin = new Padding(4, 0, 4, 0);
            lblBuktiTransaksi.Name = "lblBuktiTransaksi";
            lblBuktiTransaksi.Size = new Size(185, 22);
            lblBuktiTransaksi.TabIndex = 9;
            lblBuktiTransaksi.Text = "BUKTI TRANSAKSI";
            // 
            // lblUploadBukti
            // 
            lblUploadBukti.AutoSize = true;
            lblUploadBukti.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblUploadBukti.ForeColor = Color.FromArgb(31, 41, 55);
            lblUploadBukti.Location = new Point(38, 725);
            lblUploadBukti.Margin = new Padding(4, 0, 4, 0);
            lblUploadBukti.Name = "lblUploadBukti";
            lblUploadBukti.Size = new Size(206, 22);
            lblUploadBukti.TabIndex = 10;
            lblUploadBukti.Text = "Upload Bukti Transfer";
            // 
            // pnlUploadBukti
            // 
            pnlUploadBukti.BackColor = Color.White;
            pnlUploadBukti.BorderStyle = BorderStyle.FixedSingle;
            pnlUploadBukti.Controls.Add(lblNamaFileBukti);
            pnlUploadBukti.Cursor = Cursors.Hand;
            pnlUploadBukti.Location = new Point(38, 762);
            pnlUploadBukti.Margin = new Padding(4, 4, 4, 4);
            pnlUploadBukti.Name = "pnlUploadBukti";
            pnlUploadBukti.Size = new Size(574, 81);
            pnlUploadBukti.TabIndex = 11;
            pnlUploadBukti.Click += pnlUploadBukti_Click;
            // 
            // lblNamaFileBukti
            // 
            lblNamaFileBukti.Font = new Font("Segoe UI", 9.5F);
            lblNamaFileBukti.ForeColor = Color.FromArgb(156, 163, 175);
            lblNamaFileBukti.Location = new Point(19, 12);
            lblNamaFileBukti.Margin = new Padding(4, 0, 4, 0);
            lblNamaFileBukti.Name = "lblNamaFileBukti";
            lblNamaFileBukti.Size = new Size(538, 54);
            lblNamaFileBukti.TabIndex = 0;
            lblNamaFileBukti.Text = "📁 Pilih Berkas atau Tarik File Bukti Transaksi...";
            lblNamaFileBukti.TextAlign = ContentAlignment.MiddleCenter;
            lblNamaFileBukti.Click += pnlUploadBukti_Click;
            // 
            // pnlRekening
            // 
            pnlRekening.BackColor = Color.FromArgb(239, 246, 255);
            pnlRekening.BorderStyle = BorderStyle.FixedSingle;
            pnlRekening.Controls.Add(lblRekeningInfo);
            pnlRekening.Controls.Add(lblTransferKe);
            pnlRekening.Location = new Point(38, 544);
            pnlRekening.Margin = new Padding(4, 4, 4, 4);
            pnlRekening.Name = "pnlRekening";
            pnlRekening.Size = new Size(574, 118);
            pnlRekening.TabIndex = 8;
            // 
            // lblRekeningInfo
            // 
            lblRekeningInfo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblRekeningInfo.ForeColor = Color.FromArgb(30, 58, 138);
            lblRekeningInfo.Location = new Point(19, 48);
            lblRekeningInfo.Margin = new Padding(4, 0, 4, 0);
            lblRekeningInfo.Name = "lblRekeningInfo";
            lblRekeningInfo.Size = new Size(538, 62);
            lblRekeningInfo.TabIndex = 1;
            lblRekeningInfo.Text = "BCA 1234-5678-9012\na.n. RENTAL JOKO TANI";
            // 
            // lblTransferKe
            // 
            lblTransferKe.AutoSize = true;
            lblTransferKe.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTransferKe.ForeColor = Color.FromArgb(30, 58, 138);
            lblTransferKe.Location = new Point(19, 15);
            lblTransferKe.Margin = new Padding(4, 0, 4, 0);
            lblTransferKe.Name = "lblTransferKe";
            lblTransferKe.Size = new Size(303, 25);
            lblTransferKe.TabIndex = 0;
            lblTransferKe.Text = "Transfer Ke Rekening Pemilik Alat:";
            // 
            // lblPilihMetode
            // 
            lblPilihMetode.AutoSize = true;
            lblPilihMetode.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblPilihMetode.ForeColor = Color.FromArgb(31, 41, 55);
            lblPilihMetode.Location = new Point(38, 444);
            lblPilihMetode.Margin = new Padding(4, 0, 4, 0);
            lblPilihMetode.Name = "lblPilihMetode";
            lblPilihMetode.Size = new Size(171, 22);
            lblPilihMetode.TabIndex = 6;
            lblPilihMetode.Text = "Pilih Metode/Bank";
            // 
            // cmbMetodeBayar
            // 
            cmbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodeBayar.Font = new Font("Segoe UI", 11F);
            cmbMetodeBayar.ForeColor = Color.FromArgb(31, 41, 55);
            cmbMetodeBayar.FormattingEnabled = true;
            cmbMetodeBayar.Location = new Point(38, 481);
            cmbMetodeBayar.Margin = new Padding(4, 4, 4, 4);
            cmbMetodeBayar.Name = "cmbMetodeBayar";
            cmbMetodeBayar.Size = new Size(574, 38);
            cmbMetodeBayar.TabIndex = 7;
            cmbMetodeBayar.SelectedIndexChanged += cmbMetodeBayar_SelectedIndexChanged;
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblMetodePembayaran.ForeColor = Color.FromArgb(156, 163, 175);
            lblMetodePembayaran.Location = new Point(38, 406);
            lblMetodePembayaran.Margin = new Padding(4, 0, 4, 0);
            lblMetodePembayaran.Name = "lblMetodePembayaran";
            lblMetodePembayaran.Size = new Size(233, 22);
            lblMetodePembayaran.TabIndex = 5;
            lblMetodePembayaran.Text = "METODE PEMBAYARAN";
            // 
            // pnlTotalBayar
            // 
            pnlTotalBayar.BackColor = Color.FromArgb(240, 253, 244);
            pnlTotalBayar.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalBayar.Controls.Add(lblTotalHarga);
            pnlTotalBayar.Controls.Add(lblTextTotal);
            pnlTotalBayar.Location = new Point(38, 294);
            pnlTotalBayar.Margin = new Padding(4, 4, 4, 4);
            pnlTotalBayar.Name = "pnlTotalBayar";
            pnlTotalBayar.Size = new Size(574, 74);
            pnlTotalBayar.TabIndex = 4;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTotalHarga.ForeColor = Color.FromArgb(22, 163, 74);
            lblTotalHarga.Location = new Point(288, 18);
            lblTotalHarga.Margin = new Padding(4, 0, 4, 0);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(269, 40);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Rp 800.000";
            lblTotalHarga.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTextTotal
            // 
            lblTextTotal.AutoSize = true;
            lblTextTotal.Font = new Font("Segoe UI", 9.5F);
            lblTextTotal.ForeColor = Color.FromArgb(22, 163, 74);
            lblTextTotal.Location = new Point(19, 25);
            lblTextTotal.Margin = new Padding(4, 0, 4, 0);
            lblTextTotal.Name = "lblTextTotal";
            lblTextTotal.Size = new Size(222, 25);
            lblTextTotal.TabIndex = 0;
            lblTextTotal.Text = "Total yang harus dibayar:";
            // 
            // pnlTagihanCard
            // 
            pnlTagihanCard.BackColor = Color.FromArgb(249, 250, 251);
            pnlTagihanCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTagihanCard.Controls.Add(lblPeriode);
            pnlTagihanCard.Controls.Add(lblNamaAlat);
            pnlTagihanCard.Location = new Point(38, 156);
            pnlTagihanCard.Margin = new Padding(4, 4, 4, 4);
            pnlTagihanCard.Name = "pnlTagihanCard";
            pnlTagihanCard.Size = new Size(574, 118);
            pnlTagihanCard.TabIndex = 3;
            // 
            // lblPeriode
            // 
            lblPeriode.AutoSize = true;
            lblPeriode.Font = new Font("Segoe UI", 9.5F);
            lblPeriode.ForeColor = Color.FromArgb(75, 85, 99);
            lblPeriode.Location = new Point(19, 62);
            lblPeriode.Margin = new Padding(4, 0, 4, 0);
            lblPeriode.Name = "lblPeriode";
            lblPeriode.Size = new Size(360, 25);
            lblPeriode.TabIndex = 1;
            lblPeriode.Text = "Periode Sewa : 2026-06-08 sd 2026-06-10";
            // 
            // lblNamaAlat
            // 
            lblNamaAlat.AutoSize = true;
            lblNamaAlat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblNamaAlat.ForeColor = Color.FromArgb(31, 41, 55);
            lblNamaAlat.Location = new Point(19, 19);
            lblNamaAlat.Margin = new Padding(4, 0, 4, 0);
            lblNamaAlat.Name = "lblNamaAlat";
            lblNamaAlat.Size = new Size(240, 26);
            lblNamaAlat.TabIndex = 0;
            lblNamaAlat.Text = "Traktor Kubota L4508";
            // 
            // lblDetailTagihan
            // 
            lblDetailTagihan.AutoSize = true;
            lblDetailTagihan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblDetailTagihan.ForeColor = Color.FromArgb(156, 163, 175);
            lblDetailTagihan.Location = new Point(38, 119);
            lblDetailTagihan.Margin = new Padding(4, 0, 4, 0);
            lblDetailTagihan.Name = "lblDetailTagihan";
            lblDetailTagihan.Size = new Size(172, 22);
            lblDetailTagihan.TabIndex = 2;
            lblDetailTagihan.Text = "DETAIL TAGIHAN";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = Color.DarkGray;
            btnClose.Location = new Point(581, 19);
            btnClose.Margin = new Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(31, 41, 55);
            lblHeader.Location = new Point(38, 31);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(284, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Pembayaran Sewa";
            // 
            // vBayarSewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 956);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "vBayarSewa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "vBayarSewa";
            Load += vBayarSewa_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlUploadBukti.ResumeLayout(false);
            pnlRekening.ResumeLayout(false);
            pnlRekening.PerformLayout();
            pnlTotalBayar.ResumeLayout(false);
            pnlTotalBayar.PerformLayout();
            pnlTagihanCard.ResumeLayout(false);
            pnlTagihanCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDetailTagihan;
        private System.Windows.Forms.Panel pnlTagihanCard;
        private System.Windows.Forms.Label lblNamaAlat;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Panel pnlTotalBayar;
        private System.Windows.Forms.Label lblTextTotal;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblMetodePembayaran;
        private System.Windows.Forms.Label lblPilihMetode;
        private System.Windows.Forms.ComboBox cmbMetodeBayar;
        private System.Windows.Forms.Panel pnlRekening;
        private System.Windows.Forms.Label lblTransferKe;
        private System.Windows.Forms.Label lblRekeningInfo;
        private System.Windows.Forms.Label lblBuktiTransaksi;
        private System.Windows.Forms.Label lblUploadBukti;
        private System.Windows.Forms.Panel pnlUploadBukti;
        private System.Windows.Forms.Label lblNamaFileBukti;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKonfirmasiBayar;
    }
}