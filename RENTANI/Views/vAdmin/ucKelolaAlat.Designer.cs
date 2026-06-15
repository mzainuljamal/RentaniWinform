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
            label1 = new Label();
            label2 = new Label();
            btnTambahAlat = new Guna.UI2.WinForms.Guna2GradientButton();
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
            // ucKelolaAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTambahAlat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucKelolaAlat";
            Size = new Size(1045, 680);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnTambahAlat;
    }
}
