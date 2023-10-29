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
    public partial class updatePelatihan : Form
    {
        private DataPelatihan dtp;
        public updatePelatihan()
        {
            dtp = new DataPelatihan();
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dtp = new DataPelatihan();
            dtp.updatePelatihan(txtidpelatihan.Text, txtnamapelatihan.Text, dateTimePicker1.Value, dateTimePicker2.Value, txtinstruktur.Text, txtlokasi.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtidpelatihan.Focus();
            MessageBox.Show("Data diupdate");
            FormPelatihan frpl = new FormPelatihan();
            frpl.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPelatihan frpl = new FormPelatihan();
            frpl.Show();
            this.Hide();
        }
    }
}
