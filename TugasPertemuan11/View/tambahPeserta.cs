using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasPertemuan11.View
{
    public partial class tambahPeserta : Form
    {
        private DataPelatihan dtp;
        public tambahPeserta()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dtp = new DataPelatihan();
            dtp.tambahPeserta(txtidpeserta.Text, txtnamapeserta.Text, txtemailpeserta.Text, txtnotelppeserta.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtidpeserta.Focus();
            MessageBox.Show("Data disimpan");
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

        private void tambahPeserta_Load(object sender, EventArgs e)
        {
            txtidpeserta.MaxLength = 11;
            txtnamapeserta.MaxLength = 25;
            txtemailpeserta.MaxLength = 50;
            txtnotelppeserta.MaxLength = 12;
        }


      


    }
}
