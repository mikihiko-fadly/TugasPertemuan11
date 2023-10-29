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
    
    public partial class hapusPeserta : Form
    {
        private DataPelatihan dtp;
        public hapusPeserta()
        {
            dtp = new DataPelatihan();  
            InitializeComponent();
        }

        private void btnhapuspeserta_Click(object sender, EventArgs e)
        {
            try
            {
                dtp.hapusPeserta(txthapus.Text);
                MessageBox.Show("Berhasil dihapus", "delete data" + MessageBoxButtons.OK);
                txthapus.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void tampil()
        {
            dataGridView1.DataSource = dtp.tampilPeserta(new MySqlCommand("SELECT * FROM peserta"));
        }

        private void hapusPeserta_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPeserta frp = new FormPeserta();
            frp.Show();
            this.Hide();
        }
    }
}
