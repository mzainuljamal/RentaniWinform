namespace RentaniApp.Views.vPenyewa
{
    partial class vAjukanSewa
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpMulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpSelesai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label5 = new Label();
            cmbMetodeBayar = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            txtCatatan = new Guna.UI2.WinForms.Guna2TextBox();
            pnlDetail = new Guna.UI2.WinForms.Guna2Panel();
            lblTotalHarga = new Label();
            lblDetailDurasi = new Label();
            btnAjukanSewa = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            pnlDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(273, 32);
            label1.TabIndex = 0;
            label1.Text = "Detail Pengajuan Sewa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(13, 112);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 2;
            label3.Text = "Tanggal Mulai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(275, 112);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Selesai";
            // 
            // dtpMulai
            // 
            dtpMulai.BackColor = Color.Transparent;
            dtpMulai.BorderColor = Color.DimGray;
            dtpMulai.BorderRadius = 10;
            dtpMulai.Checked = true;
            dtpMulai.CustomizableEdges = customizableEdges1;
            dtpMulai.FillColor = Color.White;
            dtpMulai.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMulai.ForeColor = Color.Maroon;
            dtpMulai.Format = DateTimePickerFormat.Long;
            dtpMulai.Location = new Point(12, 143);
            dtpMulai.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpMulai.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpMulai.Size = new Size(217, 42);
            dtpMulai.TabIndex = 4;
            dtpMulai.Value = new DateTime(2026, 6, 21, 0, 13, 29, 831);
            dtpMulai.ValueChanged += dtpMulai_ValueChanged;
            // 
            // dtpSelesai
            // 
            dtpSelesai.BackColor = Color.Transparent;
            dtpSelesai.BorderColor = Color.DimGray;
            dtpSelesai.BorderRadius = 10;
            dtpSelesai.Checked = true;
            dtpSelesai.CustomizableEdges = customizableEdges3;
            dtpSelesai.FillColor = Color.White;
            dtpSelesai.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSelesai.ForeColor = Color.Maroon;
            dtpSelesai.Format = DateTimePickerFormat.Long;
            dtpSelesai.Location = new Point(275, 143);
            dtpSelesai.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpSelesai.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpSelesai.Name = "dtpSelesai";
            dtpSelesai.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpSelesai.Size = new Size(217, 42);
            dtpSelesai.TabIndex = 5;
            dtpSelesai.Value = new DateTime(2026, 6, 21, 0, 13, 29, 831);
            dtpSelesai.ValueChanged += dtpSelesai_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 217);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 6;
            label5.Text = "Metode Pembayaran";
            // 
            // cmbMetodeBayar
            // 
            cmbMetodeBayar.BackColor = Color.White;
            cmbMetodeBayar.BorderColor = Color.Gainsboro;
            cmbMetodeBayar.BorderRadius = 10;
            cmbMetodeBayar.CustomizableEdges = customizableEdges5;
            cmbMetodeBayar.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodeBayar.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbMetodeBayar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbMetodeBayar.Font = new Font("Segoe UI", 10F);
            cmbMetodeBayar.ForeColor = Color.Black;
            cmbMetodeBayar.ItemHeight = 30;
            cmbMetodeBayar.Location = new Point(13, 248);
            cmbMetodeBayar.Name = "cmbMetodeBayar";
            cmbMetodeBayar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbMetodeBayar.Size = new Size(480, 36);
            cmbMetodeBayar.TabIndex = 7;
            cmbMetodeBayar.SelectedIndexChanged += cmbMetodeBayar_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(12, 313);
            label6.Name = "label6";
            label6.Size = new Size(180, 28);
            label6.TabIndex = 8;
            label6.Text = "Catatan (Opsional)";
            // 
            // txtCatatan
            // 
            txtCatatan.BorderColor = Color.LightGray;
            txtCatatan.BorderRadius = 10;
            txtCatatan.CustomizableEdges = customizableEdges7;
            txtCatatan.DefaultText = "";
            txtCatatan.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCatatan.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCatatan.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCatatan.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCatatan.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCatatan.Font = new Font("Segoe UI", 9F);
            txtCatatan.ForeColor = Color.DimGray;
            txtCatatan.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCatatan.Location = new Point(13, 346);
            txtCatatan.Margin = new Padding(4, 5, 4, 5);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.PlaceholderText = "";
            txtCatatan.SelectedText = "";
            txtCatatan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCatatan.Size = new Size(479, 71);
            txtCatatan.TabIndex = 9;
            txtCatatan.TextChanged += txtCatatan_TextChanged;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.FromArgb(224, 255, 223);
            pnlDetail.BorderColor = Color.FromArgb(128, 255, 128);
            pnlDetail.BorderRadius = 10;
            pnlDetail.Controls.Add(lblTotalHarga);
            pnlDetail.Controls.Add(lblDetailDurasi);
            pnlDetail.CustomBorderColor = Color.Lime;
            pnlDetail.CustomBorderThickness = new Padding(3, 0, 0, 0);
            pnlDetail.CustomizableEdges = customizableEdges9;
            pnlDetail.Location = new Point(12, 456);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlDetail.Size = new Size(480, 73);
            pnlDetail.TabIndex = 10;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = Color.Transparent;
            lblTotalHarga.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.ForeColor = Color.ForestGreen;
            lblTotalHarga.Location = new Point(315, 25);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(162, 38);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Rp 400.000";
            lblTotalHarga.Click += lblTotalHarga_Click;
            // 
            // lblDetailDurasi
            // 
            lblDetailDurasi.AutoSize = true;
            lblDetailDurasi.BackColor = Color.Transparent;
            lblDetailDurasi.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailDurasi.Location = new Point(16, 12);
            lblDetailDurasi.Name = "lblDetailDurasi";
            lblDetailDurasi.Size = new Size(254, 21);
            lblDetailDurasi.TabIndex = 0;
            lblDetailDurasi.Text = "Durasi sewa 1 hari  (1 x Rp 400000)\r\n";
            lblDetailDurasi.Click += lblDetailDurasi_Click;
            // 
            // btnAjukanSewa
            // 
            btnAjukanSewa.Animated = true;
            btnAjukanSewa.BorderColor = Color.Transparent;
            btnAjukanSewa.BorderRadius = 10;
            btnAjukanSewa.Cursor = Cursors.Hand;
            btnAjukanSewa.CustomizableEdges = customizableEdges11;
            btnAjukanSewa.DisabledState.BorderColor = Color.DarkGray;
            btnAjukanSewa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAjukanSewa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAjukanSewa.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAjukanSewa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAjukanSewa.FillColor = Color.FromArgb(0, 0, 192);
            btnAjukanSewa.FillColor2 = Color.Blue;
            btnAjukanSewa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjukanSewa.ForeColor = Color.White;
            btnAjukanSewa.Location = new Point(275, 573);
            btnAjukanSewa.Name = "btnAjukanSewa";
            btnAjukanSewa.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAjukanSewa.Size = new Size(186, 47);
            btnAjukanSewa.TabIndex = 11;
            btnAjukanSewa.Text = "Ajukan Sewa";
            btnAjukanSewa.Click += btnAjukanSewa_Click;
            // 
            // guna2GradientButton2
            // 
            guna2GradientButton2.Animated = true;
            guna2GradientButton2.BorderColor = Color.Transparent;
            guna2GradientButton2.BorderRadius = 10;
            guna2GradientButton2.Cursor = Cursors.Hand;
            guna2GradientButton2.CustomizableEdges = customizableEdges13;
            guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton2.FillColor = Color.Silver;
            guna2GradientButton2.FillColor2 = Color.SlateGray;
            guna2GradientButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientButton2.ForeColor = Color.Black;
            guna2GradientButton2.Location = new Point(43, 573);
            guna2GradientButton2.Name = "guna2GradientButton2";
            guna2GradientButton2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2GradientButton2.Size = new Size(186, 47);
            guna2GradientButton2.TabIndex = 12;
            guna2GradientButton2.Text = "Batal";
            guna2GradientButton2.Click += guna2GradientButton2_Click;
            // 
            // vAjukanSewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(520, 680);
            Controls.Add(guna2GradientButton2);
            Controls.Add(btnAjukanSewa);
            Controls.Add(pnlDetail);
            Controls.Add(txtCatatan);
            Controls.Add(label6);
            Controls.Add(cmbMetodeBayar);
            Controls.Add(label5);
            Controls.Add(dtpSelesai);
            Controls.Add(dtpMulai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "vAjukanSewa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "vAjukanSewa";
            Load += vAjukanSewa_Load;
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMulai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSelesai;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMetodeBayar;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtCatatan;
        private Guna.UI2.WinForms.Guna2Panel pnlDetail;
        private Label lblDetailDurasi;
        private Label lblTotalHarga;
        private Guna.UI2.WinForms.Guna2GradientButton btnAjukanSewa;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}