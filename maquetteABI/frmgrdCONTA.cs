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
    public partial class frmgrdCONTA : Form
    {
        Client client;
        public frmgrdCONTA(Client client)
        {
            InitializeComponent();
            this.client = client;
            this.btnSupprimerContact.Enabled = false;
            afficheContact();
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmNewConta frmconta = new frmNewConta(client);
            if (frmconta.ShowDialog() == DialogResult.OK)
            {
                afficheContact();
            }
        }

        private void btnFermergrdContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void afficheContact()
        {
            DataTable dt = new DataTable();
            DataRow dr;
              dt.Columns.Add(new DataColumn("Numero de Contact"));
            dt.Columns.Add(new DataColumn("Nom du Contact"));
            dt.Columns.Add(new DataColumn("Fonction du Contact"));
      

            for (int i = 0; i < client.ListeContactClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = client.ListeContactClient[i].NumContact;
                dr[1] = client.ListeContactClient[i].NomContact;
                dr[2] = client.ListeContactClient[i].FonctionContact;
               
                dt.Rows.Add(dr);
            }
            this.grdContact.DataSource = dt.DefaultView;
            this.grdContact.Refresh();
            dt = null;
            dr = null;
        }

        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            if (grdContact.RowCount != 0)
            {
                client.ListeContactClient.RemoveAt(grdContact.CurrentRow.Index);
                this.afficheContact();
                this.btnSupprimerContact.Enabled = false;
            }
            ///   client.ListeContactClient.RemoveAt(grdContact.CurrentRow.Index);
            ///   this.afficheContact();
            ///  this.btnSupprimerContact.Enabled = false;
        }

        private void btnRechercherContact_Click(object sender, EventArgs e)
        {
            ((DataView)(this.grdContact.DataSource)).RowFilter = "[Numero de Contact] like '%" + this.txtRechercherContact.Text +
                 "%' or [Nom du Contact] like '%" + this.txtRechercherContact.Text +
                 "%' or [Fonction du Contact] like '%" + this.txtRechercherContact.Text +"%' " ;
        }

        private void grdContact_DoubleClick(object sender, EventArgs e)
        {
            Int32 iContact;
            iContact = this.grdContact.CurrentRow.Index;
            Contact leContact = client.ListeContactClient[iContact];
            frmContact frmcontact = new frmContact(ref leContact);
          
            frmcontact.ShowDialog();
            this.afficheContact();
        }

        private void grdContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSupprimerContact.Enabled = true;
        }
    }
}
