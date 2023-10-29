using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using TugasPertemuan11.Controller;

namespace TugasPertemuan11.View
{
    public partial class updatePeserta : Form
    {
        private DataPelatihan dtp;
        public updatePeserta()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dtp = new DataPelatihan();
            dtp.updatePeserta(txtidpeserta.Text, txtnamapeserta.Text, txtemailpeserta.Text, txtnotelppeserta.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtidpeserta.Focus();
            MessageBox.Show("Data diupdate");
            FormPeserta frp = new FormPeserta();
            frp.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPeserta frp = new FormPeserta();
            frp.Show();
            this.Hide();
        }
    }
}
