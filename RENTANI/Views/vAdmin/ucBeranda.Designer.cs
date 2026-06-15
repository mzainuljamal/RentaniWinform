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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlAlat = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            jumlahAlat = new Label();
            label1 = new Label();
            pnlAlat.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAlat
            // 
            pnlAlat.BackgroundImageLayout = ImageLayout.None;
            pnlAlat.BorderColor = Color.DarkGray;
            pnlAlat.BorderRadius = 20;
            pnlAlat.Controls.Add(jumlahAlat);
            pnlAlat.CustomizableEdges = customizableEdges1;
            pnlAlat.FillColor = Color.FromArgb(128, 128, 255);
            pnlAlat.FillColor3 = SystemColors.ActiveCaption;
            pnlAlat.ForeColor = Color.CornflowerBlue;
            pnlAlat.Location = new Point(349, 131);
            pnlAlat.Name = "pnlAlat";
            pnlAlat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlAlat.Size = new Size(265, 132);
            pnlAlat.TabIndex = 0;
            pnlAlat.Paint += pnlAlat_Paint;
            // 
            // jumlahAlat
            // 
            jumlahAlat.AutoSize = true;
            jumlahAlat.BackColor = Color.Transparent;
            jumlahAlat.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jumlahAlat.ForeColor = SystemColors.ActiveCaptionText;
            jumlahAlat.Location = new Point(32, 24);
            jumlahAlat.Name = "jumlahAlat";
            jumlahAlat.Size = new Size(95, 45);
            jumlahAlat.TabIndex = 1;
            jumlahAlat.Text = "jAlat";
            jumlahAlat.Click += jumlahAlat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 31);
            label1.Name = "label1";
            label1.Size = new Size(151, 45);
            label1.TabIndex = 2;
            label1.Text = "Beranda";
            // 
            // ucBeranda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pnlAlat);
            Name = "ucBeranda";
            Size = new Size(1045, 680);
            pnlAlat.ResumeLayout(false);
            pnlAlat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlAlat;
        private Label jumlahAlat;
        private Label label1;
    }
}
