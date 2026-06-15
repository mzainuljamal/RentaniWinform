using RentaniApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentaniApp.Views
{
    public partial class ucBeranda : UserControl
    {
        private AlatController alatController = new AlatController();

        public ucBeranda()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ucBeranda_Load);
        }

        private void ucBeranda_Load(object sender, EventArgs e)
        {
            jumlahAlat.Text = alatController.GetTotalAlat().ToString();
        }


        private void jumlahAlat_Click(object sender, EventArgs e)
        {
        }

        private void pnlAlat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}