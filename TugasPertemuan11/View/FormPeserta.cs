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

namespace TugasPertemuan11.View
{
    public partial class FormPeserta : Form
    {
        private DataPelatihan dtp;
        public FormPeserta()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void FormPeserta_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            tambahPeserta tmp = new tambahPeserta();
            tmp.Show();
            this.Hide();
        }

        public void tampil()
        {
            dataGridViewPeserta.DataSource = dtp.tampilPeserta(new MySqlCommand("SELECT * FROM peserta"));
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatePeserta updt = new updatePeserta();
            updt.Show();
            this.Hide();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            hapusPeserta hps = new hapusPeserta();
            hps.Show();
            this.Hide();
        }
    }
}
