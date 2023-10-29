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
    public partial class tambahPelatihan : Form
    {
        private DataPelatihan dtp;
        public tambahPelatihan()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void tambahPelatihan_Load(object sender, EventArgs e)
        {
            txtidpelatihan.MaxLength = 11;
            txtnamapelatihan.MaxLength = 25;
            txtinstruktur.MaxLength = 30;
            txtlokasi.MaxLength = 50;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPelatihan frpl = new FormPelatihan();
            frpl.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dtp = new DataPelatihan();
            dtp.tambahPelatihan(txtidpelatihan.Text, txtnamapelatihan.Text, dateTimePicker1.Value, dateTimePicker2.Value, txtinstruktur.Text, txtlokasi.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtidpelatihan.Focus();
            MessageBox.Show("Data disimpan");
            FormPelatihan frpl = new FormPelatihan();
            frpl.Show();
            this.Hide();

        }
    }
}
