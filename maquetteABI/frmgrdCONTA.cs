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
        /// <summary>
        /// quand je click sur ajouter  j ouvre la fiche nouveau contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmNewConta frmconta = new frmNewConta(client);
            if (frmconta.ShowDialog() == DialogResult.OK)
            {
                afficheContact();
            }
        }
        /// <summary>
        /// fermer la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermergrdContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// rétablit la source de données de la dataGridView et rafraîchit son affichage
        /// </summary>
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
        /// <summary>
        /// supprime un contact de la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerContact_Click(object sender,EventArgs e)
        {
            if (grdContact.RowCount != 0)
            {
                DialogResult rep;
                rep = MessageBox.Show("Voulez vous vraiment supprimer le Contact", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                   
                    client.ListeContactClient.RemoveAt(grdContact.CurrentRow.Index);
                    this.afficheContact();
                    this.btnSupprimerContact.Enabled = false;
                }
               
            } 
        }
        /// <summary>
        /// rechercher un contact dans ma grille, fait recherche sur tt les colomns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercherContact_Click(object sender, EventArgs e)
        {
            ((DataView)(this.grdContact.DataSource)).RowFilter = "[Numero de Contact] like '%" + this.txtRechercherContact.Text +
                 "%' or [Nom du Contact] like '%" + this.txtRechercherContact.Text +
                 "%' or [Fonction du Contact] like '%" + this.txtRechercherContact.Text +"%' " ;
        }
        /// <summary>
        /// double clic sur la grille ; ouvrir la feuille détail en y affichant le contact correspondant a la ligne double clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdContact_DoubleClick(object sender, EventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                Int32 iContact;
                iContact = this.grdContact.CurrentRow.Index;
                Contact leContact = client.ListeContactClient[iContact];
                frmContact frmcontact = new frmContact(ref leContact);

                frmcontact.ShowDialog();
                this.afficheContact();
            }
        }
        /// <summary>
        /// s'il y a des contacts sur la grille , le fait de selectioner un contact rend le bouton supprimer active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdContact.RowCount != 0)
            {
                this.btnSupprimerContact.Enabled = true;
            }
        }
    }
}
