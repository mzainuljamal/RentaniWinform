namespace RentaniApp.Views.vPenyewa
{
    partial class ucKatalogAlat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Text = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            tbCariAlat = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            flpKatalog = new FlowLayoutPanel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.BackColor = Color.Transparent;
            Text.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text.Location = new Point(22, 24);
            Text.Name = "Text";
            Text.Size = new Size(294, 38);
            Text.TabIndex = 1;
            Text.Text = "Katalog Alat Tersedia";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.Controls.Add(tbCariAlat);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(31, 91);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(885, 80);
            guna2Panel1.TabIndex = 2;
            // 
            // tbCariAlat
            // 
            tbCariAlat.BorderColor = Color.LightGray;
            tbCariAlat.BorderRadius = 10;
            tbCariAlat.Cursor = Cursors.IBeam;
            tbCariAlat.CustomizableEdges = customizableEdges1;
            tbCariAlat.DefaultText = "";
            tbCariAlat.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbCariAlat.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbCariAlat.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbCariAlat.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbCariAlat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbCariAlat.Font = new Font("Segoe UI", 9F);
            tbCariAlat.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbCariAlat.Location = new Point(4, 33);
            tbCariAlat.Margin = new Padding(4, 5, 4, 5);
            tbCariAlat.Name = "tbCariAlat";
            tbCariAlat.PlaceholderText = "Masukan Nama Alat...";
            tbCariAlat.SelectedText = "";
            tbCariAlat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbCariAlat.Size = new Size(429, 42);
            tbCariAlat.TabIndex = 3;
            tbCariAlat.TextChanged += tbCariAlat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 2;
            label1.Text = "Cari Alat";
            // 
            // flpKatalog
            // 
            flpKatalog.AutoScroll = true;
            flpKatalog.BackColor = Color.Transparent;
            flpKatalog.Location = new Point(31, 189);
            flpKatalog.Name = "flpKatalog";
            flpKatalog.Size = new Size(885, 451);
            flpKatalog.TabIndex = 3;
            flpKatalog.Paint += flpKatalog_Paint;
            // 
            // ucKatalogAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(flpKatalog);
            Controls.Add(guna2Panel1);
            Controls.Add(Text);
            Name = "ucKatalogAlat";
            Size = new Size(970, 667);
            Load += ucKatalogAlat_Load; 
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Text;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbCariAlat;
        private Label label1;
        private FlowLayoutPanel flpKatalog;
    }
}