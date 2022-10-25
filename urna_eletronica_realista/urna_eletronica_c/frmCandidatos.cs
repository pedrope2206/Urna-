using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna_eletronica_c
{
    public partial class frmCandidatos : Form
    {
        public frmCandidatos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUm  frmUm = new frmUm();
            frmUm.ShowDialog();

            frmCandidatos frmCandidatos = new frmCandidatos();
      
        }

        private void frmCandidatos_Load(object sender, EventArgs e)
        {

        }
    }
}
