using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.View;

namespace TugasPertemuan11
{
    public partial class Formutama : Form
    {
        public Formutama()
        {
            InitializeComponent();
        }

        private void btnpeserta_Click(object sender, EventArgs e)
        {
            //Agar pindah ke form 2
            FormPeserta frp = new FormPeserta();
            frp.Show();
            //Pindah form tetapi form awal disembunyikan
            this.Hide();
        }

        private void btnpelatihan_Click(object sender, EventArgs e)
        {
            FormPelatihan fprpl = new FormPelatihan();
            fprpl.Show();
            this.Hide();    
        }
    }
}
