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
    public partial class hapusPelatihan : Form
    {
        private DataPelatihan dtp;
        public hapusPelatihan()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void hapusPelatihan_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnhapuspelatihan_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void tampil()
        {
            dataGridView1.DataSource = dtp.tampilPelatihan(new MySqlCommand("SELECT * FROM pelatihan"));
        }

     

     

        private void btnhapuspeserta_Click(object sender, EventArgs e)
        {
            try
            {
                dtp.hapusPelatihan(txthapus.Text);
                MessageBox.Show("Berhasil dihapus", "delete data" + MessageBoxButtons.OK);
                txthapus.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            FormPelatihan frpl = new FormPelatihan();
            frpl.Show();
            this.Hide();
        }
    }
}
