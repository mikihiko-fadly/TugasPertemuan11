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
using static System.Net.WebRequestMethods;

namespace TugasPertemuan11.View
{
    public partial class FormPelatihan : Form
    {
        private DataPelatihan dtp;
        public FormPelatihan()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            tambahPelatihan tmpl = new tambahPelatihan();
            tmpl.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatePelatihan updtpl = new updatePelatihan();
            updtpl.Show();
            this.Hide();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            hapusPelatihan hpspl = new hapusPelatihan();
            hpspl.Show();
            this.Hide();
        }


        public void tampil()
        {
            dataGridViewPelatihan.DataSource = dtp.tampilPelatihan(new MySqlCommand("SELECT * FROM pelatihan"));
        }

        private void FormPelatihan_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
