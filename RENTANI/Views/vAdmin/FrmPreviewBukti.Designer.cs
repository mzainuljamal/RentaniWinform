namespace RentaniApp.Views.vAdmin
{
    partial class FrmPreviewBukti
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
            pbBukti = new PictureBox();
            btnTutup = new Button();
            lblDetail = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBukti).BeginInit();
            SuspendLayout();
            // 
            // pbBukti
            // 
            pbBukti.BackColor = Color.FromArgb(243, 244, 246);
            pbBukti.Location = new Point(25, 69);
            pbBukti.Name = "pbBukti";
            pbBukti.Size = new Size(512, 600);
            pbBukti.SizeMode = PictureBoxSizeMode.Zoom;
            pbBukti.TabIndex = 0;
            pbBukti.TabStop = false;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.FromArgb(31, 41, 55);
            btnTutup.Cursor = Cursors.Hand;
            btnTutup.FlatAppearance.BorderSize = 0;
            btnTutup.FlatStyle = FlatStyle.Flat;
            btnTutup.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnTutup.ForeColor = Color.White;
            btnTutup.Location = new Point(25, 688);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(512, 50);
            btnTutup.TabIndex = 1;
            btnTutup.Text = "Tutup Jendela";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDetail.ForeColor = Color.FromArgb(17, 24, 39);
            lblDetail.Location = new Point(25, 25);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(292, 30);
            lblDetail.TabIndex = 2;
            lblDetail.Text = "Transaksi ID: #0 | Penyewa: -";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.FromArgb(243, 244, 246);
            lblError.Font = new Font("Segoe UI", 10F);
            lblError.ForeColor = Color.FromArgb(156, 163, 175);
            lblError.Location = new Point(175, 350);
            lblError.Name = "lblError";
            lblError.Size = new Size(217, 28);
            lblError.TabIndex = 3;
            lblError.Text = "Gagal memuat gambar.";
            lblError.Visible = false;
            // 
            // FrmPreviewBukti
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 762);
            Controls.Add(lblError);
            Controls.Add(lblDetail);
            Controls.Add(btnTutup);
            Controls.Add(pbBukti);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPreviewBukti";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Preview Bukti Transaksi";
            Load += FrmPreviewBukti_Load;
            ((System.ComponentModel.ISupportInitialize)pbBukti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBukti;
        private Button btnTutup;
        private Label lblDetail;
        private Label lblError;
    }
}