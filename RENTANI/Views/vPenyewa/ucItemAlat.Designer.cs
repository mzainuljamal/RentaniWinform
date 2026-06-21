namespace RentaniApp.Views.vPenyewa
{
    partial class ucItemAlat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picAlat = new Guna.UI2.WinForms.Guna2PictureBox();
            lblKategori = new Label();
            lblNamaAlat = new Label();
            lblStok = new Label();
            lblHarga = new Label();
            btnSewaSekarang = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)picAlat).BeginInit();
            SuspendLayout();
            // 
            // picAlat
            // 
            picAlat.BackColor = Color.Transparent;
            picAlat.BorderRadius = 10;
            picAlat.CustomizableEdges = customizableEdges5;
            picAlat.FillColor = Color.WhiteSmoke;
            picAlat.ImageRotate = 0F;
            picAlat.Location = new Point(15, 18);
            picAlat.Name = "picAlat";
            picAlat.ShadowDecoration.CustomizableEdges = customizableEdges6;
            picAlat.Size = new Size(191, 112);
            picAlat.SizeMode = PictureBoxSizeMode.Zoom;
            picAlat.TabIndex = 0;
            picAlat.TabStop = false;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategori.ForeColor = Color.RoyalBlue;
            lblKategori.Location = new Point(15, 142);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(75, 21);
            lblKategori.TabIndex = 1;
            lblKategori.Text = "Kategori";
            // 
            // lblNamaAlat
            // 
            lblNamaAlat.AutoSize = true;
            lblNamaAlat.BackColor = Color.Transparent;
            lblNamaAlat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaAlat.ForeColor = Color.Black;
            lblNamaAlat.Location = new Point(15, 173);
            lblNamaAlat.Name = "lblNamaAlat";
            lblNamaAlat.Size = new Size(107, 28);
            lblNamaAlat.TabIndex = 2;
            lblNamaAlat.Text = "NamaAlat";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.Transparent;
            lblStok.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStok.ForeColor = Color.DarkGray;
            lblStok.Location = new Point(15, 201);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(88, 21);
            lblStok.TabIndex = 3;
            lblStok.Text = "Tersedia : 1";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.Green;
            lblHarga.Location = new Point(15, 233);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(187, 28);
            lblHarga.TabIndex = 4;
            lblHarga.Text = "Rp 400.000  / Hari";
            // 
            // btnSewaSekarang
            // 
            btnSewaSekarang.BackColor = Color.Transparent;
            btnSewaSekarang.BorderColor = Color.Transparent;
            btnSewaSekarang.BorderRadius = 10;
            btnSewaSekarang.Cursor = Cursors.Hand;
            btnSewaSekarang.CustomizableEdges = customizableEdges7;
            btnSewaSekarang.DisabledState.BorderColor = Color.DarkGray;
            btnSewaSekarang.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSewaSekarang.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSewaSekarang.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSewaSekarang.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSewaSekarang.FillColor = Color.FromArgb(0, 0, 192);
            btnSewaSekarang.FillColor2 = Color.Blue;
            btnSewaSekarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSewaSekarang.ForeColor = Color.White;
            btnSewaSekarang.Location = new Point(15, 282);
            btnSewaSekarang.Name = "btnSewaSekarang";
            btnSewaSekarang.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSewaSekarang.Size = new Size(187, 35);
            btnSewaSekarang.TabIndex = 5;
            btnSewaSekarang.Text = "Sewa";
            btnSewaSekarang.Click += btnSewaSekarang_Click;
            // 
            // ucItemAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSewaSekarang);
            Controls.Add(lblHarga);
            Controls.Add(lblStok);
            Controls.Add(lblNamaAlat);
            Controls.Add(lblKategori);
            Controls.Add(picAlat);
            Margin = new Padding(10);
            Name = "ucItemAlat";
            Size = new Size(220, 340);
            Load += ucItemAlat_Load;
            ((System.ComponentModel.ISupportInitialize)picAlat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picAlat;
        private Label lblKategori;
        private Label lblNamaAlat;
        private Label lblStok;
        private Label lblHarga;
        private Guna.UI2.WinForms.Guna2GradientButton btnSewaSekarang;
    }
}