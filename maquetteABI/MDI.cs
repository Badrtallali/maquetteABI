using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquetteABI
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();

        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrdCLIE frmg = new frmgrdCLIE();
            DialogResult rep = frmg.ShowDialog();
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Voulez vous vraiment quitter", "Terminer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
