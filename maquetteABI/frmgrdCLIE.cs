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
    public partial class frmgrdCLIE : Form
    {
        public frmgrdCLIE()
        {
            InitializeComponent();
            this.btnSupprimer.Enabled = false;
            afficheClient();
        }

        private void btnFermergrdClient_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

   

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmc = new frmNewClient();
           if(frmc.ShowDialog()==DialogResult.OK)
            {
                afficheClient();
            }

        }

        private void afficheClient()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numero de Client"));
            dt.Columns.Add(new DataColumn("Raison Sociale"));
            dt.Columns.Add(new DataColumn("Ville du Client"));
            dt.Columns.Add(new DataColumn("Code Postale Du Client"));
         
            for (int i = 0; i < Donnees.ArrayClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ArrayClient[i].NumClient;
                dr[1] = Donnees.ArrayClient[i].RaisoClient;
                dr[2] = Donnees.ArrayClient[i].VilleClient;
                dr[3] = Donnees.ArrayClient[i].CodePostalClient;
                dt.Rows.Add(dr);
            }
            this.grdClient.DataSource = dt.DefaultView;
            this.grdClient.Refresh();
            dt = null;
            dr = null;
        }
        private void frmgrdCLIE_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (grdClient.RowCount != 0 )
            {
                Donnees.ArrayClient.RemoveAt(grdClient.CurrentRow.Index);
                this.afficheClient();
                this.btnSupprimer.Enabled = false;
            }
        }

        private void btnRechercherClient_Click(object sender, EventArgs e)
        {
            ((DataView)(this.grdClient.DataSource)).RowFilter = "[Numero de Client] like '%" + this.txtRechercherClient.Text +
                  "%' or [Raison Sociale] like '%" + this.txtRechercherClient.Text +
                  "%' or [Ville du Client] like '%" + this.txtRechercherClient.Text +
                  "%' or [Code Postale Du Client] like '%" + this.txtRechercherClient.Text + "%' ";

        }

        private void grdClient_DoubleClick_1(object sender, EventArgs e)
        {
            Int32 iClient;
            iClient = this.grdClient.CurrentRow.Index;
            Client leClient = Donnees.ArrayClient[iClient];

            frmCLIE frmclient = new frmCLIE(leClient);
            frmclient.ShowDialog();
            
            this.afficheClient();
            

        }

       

        private void grdClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClient.RowCount != 0)
            {
                this.btnSupprimer.Enabled = true;
            }
        }
    }
}
