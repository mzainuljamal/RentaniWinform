namespace RentaniApp.Views.vAdmin
{
    partial class ucUlasan
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
            lblTitle = new Label();
            lblSection = new Label();
            pnlCardTotal = new Panel();
            lblValTotalUlasan = new Label();
            lblKetTotalUlasan = new Label();
            pnlCardRating = new Panel();
            lblValRating = new Label();
            lblKetRating = new Label();
            flpContainerUlasan = new FlowLayoutPanel();
            pnlCardTotal.SuspendLayout();
            pnlCardRating.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(336, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ulasan";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSection.ForeColor = Color.FromArgb(31, 41, 55);
            lblSection.Location = new Point(336, 114);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(239, 32);
            lblSection.TabIndex = 2;
            lblSection.Text = "Ulasan dari Penyewa";
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.White;
            pnlCardTotal.Controls.Add(lblValTotalUlasan);
            pnlCardTotal.Controls.Add(lblKetTotalUlasan);
            pnlCardTotal.Location = new Point(339, 154);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(230, 100);
            pnlCardTotal.TabIndex = 3;
            // 
            // lblValTotalUlasan
            // 
            lblValTotalUlasan.AutoSize = true;
            lblValTotalUlasan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValTotalUlasan.ForeColor = Color.FromArgb(31, 41, 55);
            lblValTotalUlasan.Location = new Point(20, 10);
            lblValTotalUlasan.Name = "lblValTotalUlasan";
            lblValTotalUlasan.Size = new Size(46, 54);
            lblValTotalUlasan.TabIndex = 0;
            lblValTotalUlasan.Text = "3";
            // 
            // lblKetTotalUlasan
            // 
            lblKetTotalUlasan.AutoSize = true;
            lblKetTotalUlasan.Font = new Font("Segoe UI", 8.5F);
            lblKetTotalUlasan.ForeColor = Color.FromArgb(107, 114, 128);
            lblKetTotalUlasan.Location = new Point(20, 60);
            lblKetTotalUlasan.Name = "lblKetTotalUlasan";
            lblKetTotalUlasan.Size = new Size(102, 23);
            lblKetTotalUlasan.TabIndex = 1;
            lblKetTotalUlasan.Text = "Total Ulasan";
            // 
            // pnlCardRating
            // 
            pnlCardRating.BackColor = Color.White;
            pnlCardRating.Controls.Add(lblValRating);
            pnlCardRating.Controls.Add(lblKetRating);
            pnlCardRating.Location = new Point(589, 154);
            pnlCardRating.Name = "pnlCardRating";
            pnlCardRating.Size = new Size(230, 100);
            pnlCardRating.TabIndex = 4;
            // 
            // lblValRating
            // 
            lblValRating.AutoSize = true;
            lblValRating.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValRating.ForeColor = Color.FromArgb(31, 41, 55);
            lblValRating.Location = new Point(20, 10);
            lblValRating.Name = "lblValRating";
            lblValRating.Size = new Size(125, 54);
            lblValRating.TabIndex = 0;
            lblValRating.Text = "4.7 ★";
            // 
            // lblKetRating
            // 
            lblKetRating.AutoSize = true;
            lblKetRating.Font = new Font("Segoe UI", 8.5F);
            lblKetRating.ForeColor = Color.FromArgb(107, 114, 128);
            lblKetRating.Location = new Point(20, 60);
            lblKetRating.Name = "lblKetRating";
            lblKetRating.Size = new Size(135, 23);
            lblKetRating.TabIndex = 1;
            lblKetRating.Text = "Rating Rata-rata";
            // 
            // flpContainerUlasan
            // 
            flpContainerUlasan.AutoScroll = true;
            flpContainerUlasan.Location = new Point(339, 279);
            flpContainerUlasan.Name = "flpContainerUlasan";
            flpContainerUlasan.Size = new Size(933, 375);
            flpContainerUlasan.TabIndex = 5;
            // 
            // ucUlasan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(flpContainerUlasan);
            Controls.Add(pnlCardRating);
            Controls.Add(pnlCardTotal);
            Controls.Add(lblSection);
            Controls.Add(lblTitle);
            Name = "ucUlasan";
            Size = new Size(1312, 680);
            Load += ucUlasan_Load;
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlCardRating.ResumeLayout(false);
            pnlCardRating.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSection;
        private Panel pnlCardTotal;
        private Label lblValTotalUlasan;
        private Label lblKetTotalUlasan;
        private Panel pnlCardRating;
        private Label lblValRating;
        private Label lblKetRating;
        private FlowLayoutPanel flpContainerUlasan;
    }
}