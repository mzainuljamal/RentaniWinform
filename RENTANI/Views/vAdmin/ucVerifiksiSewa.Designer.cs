namespace RentaniApp.Views.vAdmin
{
    partial class ucVerifiksiSewa
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            dgvVerifikasi = new Guna.UI2.WinForms.Guna2DataGridView();
            idSewaCol = new DataGridViewTextBoxColumn();
            penyewaCol = new DataGridViewTextBoxColumn();
            alatCol = new DataGridViewTextBoxColumn();
            mulaiCol = new DataGridViewTextBoxColumn();
            selesaiCol = new DataGridViewTextBoxColumn();
            totalCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            btnSetujuCol = new DataGridViewButtonColumn();
            btnTolakCol = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVerifikasi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 40);
            label1.Name = "label1";
            label1.Size = new Size(260, 45);
            label1.TabIndex = 4;
            label1.Text = "Verifikasi Sewa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(341, 148);
            label2.Name = "label2";
            label2.Size = new Size(362, 32);
            label2.TabIndex = 5;
            label2.Text = "Verifikasi Pengajuan Penyewaan";
            // 
            // dgvVerifikasi
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dgvVerifikasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVerifikasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVerifikasi.ColumnHeadersHeight = 52;
            dgvVerifikasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvVerifikasi.Columns.AddRange(new DataGridViewColumn[] { idSewaCol, penyewaCol, alatCol, mulaiCol, selesaiCol, totalCol, statusCol, btnSetujuCol, btnTolakCol });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvVerifikasi.DefaultCellStyle = dataGridViewCellStyle5;
            dgvVerifikasi.GridColor = Color.FromArgb(232, 232, 232);
            dgvVerifikasi.Location = new Point(341, 204);
            dgvVerifikasi.Name = "dgvVerifikasi";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvVerifikasi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvVerifikasi.RowHeadersVisible = false;
            dgvVerifikasi.RowHeadersWidth = 62;
            dgvVerifikasi.RowTemplate.Height = 40;
            dgvVerifikasi.Size = new Size(939, 444);
            dgvVerifikasi.TabIndex = 6;
            dgvVerifikasi.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(236, 236, 236);
            dgvVerifikasi.ThemeStyle.GridColor = Color.FromArgb(232, 232, 232);
            dgvVerifikasi.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 232, 232);
            dgvVerifikasi.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvVerifikasi.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvVerifikasi.ThemeStyle.HeaderStyle.Height = 52;
            dgvVerifikasi.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvVerifikasi.ThemeStyle.RowsStyle.Height = 40;
            dgvVerifikasi.CellContentClick += guna2DataGridView1_CellContentClick;
            dgvVerifikasi.CellMouseMove += dgvVerifikasi_CellMouseMove;
            // 
            // idSewaCol
            // 
            idSewaCol.HeaderText = "ID";
            idSewaCol.MinimumWidth = 8;
            idSewaCol.Name = "idSewaCol";
            // 
            // penyewaCol
            // 
            penyewaCol.HeaderText = "Penyewa";
            penyewaCol.MinimumWidth = 8;
            penyewaCol.Name = "penyewaCol";
            // 
            // alatCol
            // 
            alatCol.HeaderText = "Alat Pertanian";
            alatCol.MinimumWidth = 8;
            alatCol.Name = "alatCol";
            // 
            // mulaiCol
            // 
            mulaiCol.HeaderText = "Mulai";
            mulaiCol.MinimumWidth = 8;
            mulaiCol.Name = "mulaiCol";
            // 
            // selesaiCol
            // 
            selesaiCol.HeaderText = "Selesai";
            selesaiCol.MinimumWidth = 8;
            selesaiCol.Name = "selesaiCol";
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
            // btnSetujuCol
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Lime;
            btnSetujuCol.DefaultCellStyle = dataGridViewCellStyle3;
            btnSetujuCol.HeaderText = "Setuju";
            btnSetujuCol.MinimumWidth = 8;
            btnSetujuCol.Name = "btnSetujuCol";
            btnSetujuCol.Resizable = DataGridViewTriState.True;
            btnSetujuCol.Text = "✔";
            btnSetujuCol.UseColumnTextForButtonValue = true;
            // 
            // btnTolakCol
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Red;
            btnTolakCol.DefaultCellStyle = dataGridViewCellStyle4;
            btnTolakCol.HeaderText = "Tolak";
            btnTolakCol.MinimumWidth = 8;
            btnTolakCol.Name = "btnTolakCol";
            btnTolakCol.Resizable = DataGridViewTriState.True;
            btnTolakCol.Text = "X";
            btnTolakCol.UseColumnTextForButtonValue = true;
            // 
            // ucVerifiksiSewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvVerifikasi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucVerifiksiSewa";
            Size = new Size(1312, 680);
            Load += ucVerifiksiSewa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVerifikasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVerifikasi;
        private DataGridViewTextBoxColumn idSewaCol;
        private DataGridViewTextBoxColumn penyewaCol;
        private DataGridViewTextBoxColumn alatCol;
        private DataGridViewTextBoxColumn mulaiCol;
        private DataGridViewTextBoxColumn selesaiCol;
        private DataGridViewTextBoxColumn totalCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewButtonColumn btnSetujuCol;
        private DataGridViewButtonColumn btnTolakCol;
    }
}
