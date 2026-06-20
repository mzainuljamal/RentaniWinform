namespace RentaniApp.Views.vAdmin
{
    partial class ucRiwayatSewa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            dgvRiwayat = new Guna.UI2.WinForms.Guna2DataGridView();
            idCol = new DataGridViewTextBoxColumn();
            penyewaCol = new DataGridViewTextBoxColumn();
            alatCol = new DataGridViewTextBoxColumn();
            periodeCol = new DataGridViewTextBoxColumn();
            totalCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            pembayaranCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 30);
            label1.Name = "label1";
            label1.Size = new Size(236, 45);
            label1.TabIndex = 5;
            label1.Text = "Riwayat Sewa";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 141);
            label2.Name = "label2";
            label2.Size = new Size(322, 32);
            label2.TabIndex = 6;
            label2.Text = "Riwayat Semua Penyewaan";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRiwayat.ColumnHeadersHeight = 40;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { idCol, penyewaCol, alatCol, periodeCol, totalCol, statusCol, pembayaranCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(247, 248, 249);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRiwayat.GridColor = Color.FromArgb(247, 248, 249);
            dgvRiwayat.Location = new Point(301, 198);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.Size = new Size(968, 443);
            dgvRiwayat.TabIndex = 7;
            dgvRiwayat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            dgvRiwayat.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRiwayat.ThemeStyle.GridColor = Color.FromArgb(247, 248, 249);
            dgvRiwayat.ThemeStyle.HeaderStyle.BackColor = Color.WhiteSmoke;
            dgvRiwayat.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvRiwayat.ThemeStyle.HeaderStyle.ForeColor = Color.Gray;
            dgvRiwayat.ThemeStyle.HeaderStyle.Height = 40;
            dgvRiwayat.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(247, 248, 249);
            dgvRiwayat.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRiwayat.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvRiwayat.ThemeStyle.RowsStyle.Height = 33;
            dgvRiwayat.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dgvRiwayat.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvRiwayat.CellFormatting += dgvRiwayat_CellFormatting;
            // 
            // idCol
            // 
            idCol.HeaderText = "ID";
            idCol.MinimumWidth = 8;
            idCol.Name = "idCol";
            // 
            // penyewaCol
            // 
            penyewaCol.HeaderText = "Penyewa";
            penyewaCol.MinimumWidth = 8;
            penyewaCol.Name = "penyewaCol";
            // 
            // alatCol
            // 
            alatCol.HeaderText = "Alat";
            alatCol.MinimumWidth = 8;
            alatCol.Name = "alatCol";
            // 
            // periodeCol
            // 
            periodeCol.HeaderText = "Periode";
            periodeCol.MinimumWidth = 8;
            periodeCol.Name = "periodeCol";
            // 
            // totalCol
            // 
            totalCol.HeaderText = "Total";
            totalCol.MinimumWidth = 8;
            totalCol.Name = "totalCol";
            // 
            // statusCol
            // 
            statusCol.HeaderText = "Status";
            statusCol.MinimumWidth = 8;
            statusCol.Name = "statusCol";
            // 
            // pembayaranCol
            // 
            pembayaranCol.HeaderText = "Pembayaran";
            pembayaranCol.MinimumWidth = 8;
            pembayaranCol.Name = "pembayaranCol";
            // 
            // ucRiwayatSewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRiwayat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucRiwayatSewa";
            Size = new Size(1312, 680);
            Load += ucRiwayatSewa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRiwayat;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn penyewaCol;
        private DataGridViewTextBoxColumn alatCol;
        private DataGridViewTextBoxColumn periodeCol;
        private DataGridViewTextBoxColumn totalCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn pembayaranCol;
    }
}
