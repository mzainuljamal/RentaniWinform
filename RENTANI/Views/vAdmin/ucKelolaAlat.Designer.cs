namespace RentaniApp.Views.vAdmin
{
    partial class ucKelolaAlat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            btnTambahAlat = new Guna.UI2.WinForms.Guna2GradientButton();
            dgvAlat = new DataGridView();
            Gambar = new DataGridViewImageColumn();
            NamaAlat = new DataGridViewTextBoxColumn();
            Kategori = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Kondisi = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEditColumn = new DataGridViewImageColumn();
            btnHapusColumn = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 26);
            label1.Name = "label1";
            label1.Size = new Size(192, 45);
            label1.TabIndex = 3;
            label1.Text = "Kelola Alat";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(327, 121);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 4;
            label2.Text = "Daftar Alat Saya";
            // 
            // btnTambahAlat
            // 
            btnTambahAlat.Animated = true;
            btnTambahAlat.BorderRadius = 20;
            btnTambahAlat.Cursor = Cursors.Hand;
            btnTambahAlat.CustomizableEdges = customizableEdges1;
            btnTambahAlat.DisabledState.BorderColor = Color.DarkGray;
            btnTambahAlat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTambahAlat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTambahAlat.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnTambahAlat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTambahAlat.FillColor = Color.FromArgb(0, 0, 192);
            btnTambahAlat.FillColor2 = Color.RoyalBlue;
            btnTambahAlat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahAlat.ForeColor = Color.White;
            btnTambahAlat.Image = Properties.Resources.Talat1;
            btnTambahAlat.Location = new Point(327, 166);
            btnTambahAlat.Name = "btnTambahAlat";
            btnTambahAlat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTambahAlat.Size = new Size(198, 46);
            btnTambahAlat.TabIndex = 5;
            btnTambahAlat.Text = "Tambah Alat";
            btnTambahAlat.TextOffset = new Point(3, 0);
            btnTambahAlat.Click += btnTambahAlat_Click;
            // 
            // dgvAlat
            // 
            dgvAlat.AllowUserToAddRows = false;
            dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlat.BackgroundColor = Color.White;
            dgvAlat.BorderStyle = BorderStyle.Fixed3D;
            dgvAlat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlat.Columns.AddRange(new DataGridViewColumn[] { Gambar, NamaAlat, Kategori, Harga, Stok, Kondisi, Status, btnEditColumn, btnHapusColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlat.EnableHeadersVisualStyles = false;
            dgvAlat.GridColor = Color.LightGray;
            dgvAlat.Location = new Point(327, 236);
            dgvAlat.Name = "dgvAlat";
            dgvAlat.RowHeadersVisible = false;
            dgvAlat.RowHeadersWidth = 62;
            dgvAlat.RowTemplate.Height = 40;
            dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlat.Size = new Size(949, 423);
            dgvAlat.TabIndex = 6;
            dgvAlat.CellContentClick += dgvAlat_CellContentClick_1;
            // 
            // Gambar
            // 
            Gambar.HeaderText = "Gambar";
            Gambar.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Gambar.MinimumWidth = 8;
            Gambar.Name = "Gambar";
            // 
            // NamaAlat
            // 
            NamaAlat.HeaderText = "Nama Alat";
            NamaAlat.MinimumWidth = 8;
            NamaAlat.Name = "NamaAlat";
            // 
            // Kategori
            // 
            Kategori.HeaderText = "Kategori";
            Kategori.MinimumWidth = 8;
            Kategori.Name = "Kategori";
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga/hari";
            Harga.MinimumWidth = 8;
            Harga.Name = "Harga";
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 8;
            Stok.Name = "Stok";
            // 
            // Kondisi
            // 
            Kondisi.HeaderText = "Kondisi";
            Kondisi.MinimumWidth = 8;
            Kondisi.Name = "Kondisi";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            // 
            // btnEditColumn
            // 
            btnEditColumn.HeaderText = "Edit";
            btnEditColumn.Image = Properties.Resources.Group__1_;
            btnEditColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btnEditColumn.MinimumWidth = 8;
            btnEditColumn.Name = "btnEditColumn";
            btnEditColumn.Resizable = DataGridViewTriState.True;
            btnEditColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnHapusColumn
            // 
            btnHapusColumn.HeaderText = "Hapus";
            btnHapusColumn.Image = Properties.Resources.Group__2_;
            btnHapusColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btnHapusColumn.MinimumWidth = 8;
            btnHapusColumn.Name = "btnHapusColumn";
            // 
            // ucKelolaAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAlat);
            Controls.Add(btnTambahAlat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucKelolaAlat";
            Size = new Size(1312, 680);
            Load += ucKelolaAlat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnTambahAlat;
        private DataGridView dgvAlat;
        private DataGridViewImageColumn Gambar;
        private DataGridViewTextBoxColumn NamaAlat;
        private DataGridViewTextBoxColumn Kategori;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Kondisi;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewImageColumn btnEditColumn;
        private DataGridViewImageColumn btnHapusColumn;
    }
}
