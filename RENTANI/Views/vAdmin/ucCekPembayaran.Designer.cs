namespace RentaniApp.Views.vAdmin
{
    partial class ucCekPembayaran
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label3 = new Label();
            dgvPembayaran = new Guna.UI2.WinForms.Guna2DataGridView();
            idPembayaranCol = new DataGridViewTextBoxColumn();
            namaPenyewaCol = new DataGridViewTextBoxColumn();
            namaAlatCol = new DataGridViewTextBoxColumn();
            jumlahBayarCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            viewBuktiCol = new DataGridViewImageColumn();
            btnVerifikasiCol = new DataGridViewImageColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 25);
            label1.Name = "label1";
            label1.Size = new Size(329, 45);
            label1.TabIndex = 4;
            label1.Text = "Pembayaran Masuk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(327, 140);
            label2.Name = "label2";
            label2.Size = new Size(369, 32);
            label2.TabIndex = 5;
            label2.Text = "Konfirmasi Pembayaran Masuk";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.Yellow;
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.FromArgb(254, 255, 210);
            guna2Panel1.Location = new Point(327, 186);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(922, 55);
            guna2Panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(36, 13);
            label3.Name = "label3";
            label3.Size = new Size(637, 25);
            label3.TabIndex = 0;
            label3.Text = "⚠️ Periksa bukti transfer dari penyewa sebelum mengonfirmasi pembayaran.";
            // 
            // dgvPembayaran
            // 
            dgvPembayaran.AllowUserToAddRows = false;
            dgvPembayaran.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPembayaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPembayaran.ColumnHeadersHeight = 40;
            dgvPembayaran.Columns.AddRange(new DataGridViewColumn[] { idPembayaranCol, namaPenyewaCol, namaAlatCol, jumlahBayarCol, statusCol, viewBuktiCol, btnVerifikasiCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPembayaran.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPembayaran.GridColor = SystemColors.ButtonFace;
            dgvPembayaran.Location = new Point(327, 258);
            dgvPembayaran.Name = "dgvPembayaran";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPembayaran.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPembayaran.RowHeadersVisible = false;
            dgvPembayaran.RowHeadersWidth = 62;
            dgvPembayaran.Size = new Size(922, 389);
            dgvPembayaran.TabIndex = 7;
            dgvPembayaran.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPembayaran.ThemeStyle.GridColor = SystemColors.ButtonFace;
            dgvPembayaran.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvPembayaran.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvPembayaran.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvPembayaran.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPembayaran.ThemeStyle.HeaderStyle.Height = 40;
            dgvPembayaran.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPembayaran.ThemeStyle.RowsStyle.Height = 33;
            // 
            // idPembayaranCol
            // 
            idPembayaranCol.HeaderText = "ID";
            idPembayaranCol.MinimumWidth = 8;
            idPembayaranCol.Name = "idPembayaranCol";
            // 
            // namaPenyewaCol
            // 
            namaPenyewaCol.HeaderText = "Nama";
            namaPenyewaCol.MinimumWidth = 8;
            namaPenyewaCol.Name = "namaPenyewaCol";
            // 
            // namaAlatCol
            // 
            namaAlatCol.HeaderText = "Alat";
            namaAlatCol.MinimumWidth = 8;
            namaAlatCol.Name = "namaAlatCol";
            // 
            // jumlahBayarCol
            // 
            jumlahBayarCol.HeaderText = "Total";
            jumlahBayarCol.MinimumWidth = 8;
            jumlahBayarCol.Name = "jumlahBayarCol";
            // 
            // statusCol
            // 
            statusCol.HeaderText = "Status";
            statusCol.MinimumWidth = 8;
            statusCol.Name = "statusCol";
            // 
            // viewBuktiCol
            // 
            viewBuktiCol.HeaderText = "Bukti";
            viewBuktiCol.Image = Properties.Resources.Group__3_;
            viewBuktiCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            viewBuktiCol.MinimumWidth = 8;
            viewBuktiCol.Name = "viewBuktiCol";
            // 
            // btnVerifikasiCol
            // 
            btnVerifikasiCol.HeaderText = "Konfirmasi";
            btnVerifikasiCol.Image = Properties.Resources.Group__4_;
            btnVerifikasiCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            btnVerifikasiCol.MinimumWidth = 8;
            btnVerifikasiCol.Name = "btnVerifikasiCol";
            // 
            // ucCekPembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPembayaran);
            Controls.Add(guna2Panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucCekPembayaran";
            Size = new Size(1312, 680);
            Load += ucCekPembayaran_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPembayaran;
        private DataGridViewTextBoxColumn idPembayaranCol;
        private DataGridViewTextBoxColumn namaPenyewaCol;
        private DataGridViewTextBoxColumn namaAlatCol;
        private DataGridViewTextBoxColumn jumlahBayarCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewImageColumn viewBuktiCol;
        private DataGridViewImageColumn btnVerifikasiCol;
    }
}
