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
        /// <summary>
        /// fermer la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermergrdClient_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        ///   instancier un form de saisie de Client puis réafficher la datagridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmc = new frmNewClient();
           if(frmc.ShowDialog()==DialogResult.OK)
            {
                afficheClient();
            }
        }
        /// <summary>
        ///  rétablit la source de données de la dataGridView et rafraîchit son affichage 
        /// </summary>
        private void afficheClient()
        {
            // DataTable : pour recopier les Client 
            // (stockés en collection) 
            // à relier au DataGridView pour personnaliser son affichage

            DataTable dt = new DataTable();
            DataRow dr;
            //cree une colone qui souvegarde l index 
            dt.Columns.Add(new DataColumn("indexClient",typeof(Int32 )));
// ajout à la datatable de 4 colonnes personnalisées
            dt.Columns.Add(new DataColumn("Numero de Client"));
            dt.Columns.Add(new DataColumn("Raison Sociale"));
            dt.Columns.Add(new DataColumn("Ville du Client"));
            dt.Columns.Add(new DataColumn("Code Postale Du Client"));
            // boucle remplissage de la DataTable à partir de la collection
            for (int i = 0; i < Donnees.ArrayClient.Count; i++)
            { 
                dr = dt.NewRow();

                dr[0] = i;
                dr[1] = Donnees.ArrayClient[i].NumClient;
                dr[2] = Donnees.ArrayClient[i].RaisoClient;
                dr[3] = Donnees.ArrayClient[i].VilleClient;
                dr[4] = Donnees.ArrayClient[i].CodePostalClient;
                dt.Rows.Add(dr);

            }

            // déterminer l'origine des données à afficher en DataGridView
            this.grdClient.DataSource = dt.DefaultView;

            //rendre invisible ma premiere colomn
            grdClient.Columns[0].Visible = false;
            
            this.grdClient.Refresh();
            dt = null;
            dr = null;
        }      
        /// <summary>
        /// supprime un client de la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (grdClient.RowCount != 0 )
            {
                DialogResult rep;
                rep = MessageBox.Show("Voulez vous vraiment supprimer le Contact", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    Donnees.ArrayClient.RemoveAt(Convert.ToInt32(grdClient[0, grdClient.CurrentRow.Index].Value));       // Renaud the great  idea 
                    this.afficheClient();
                    this.btnSupprimer.Enabled = false;
                }
                
            }
        }
        /// <summary>
        /// rechercher un client dans ma grille, fait recherche sur tt les colomns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercherClient_Click(object sender, EventArgs e)
        {
            ((DataView)(this.grdClient.DataSource)).RowFilter = "[Numero de Client] like '%" + this.txtRechercherClient.Text +
                  "%' or [Raison Sociale] like '%" + this.txtRechercherClient.Text +
                  "%' or [Ville du Client] like '%" + this.txtRechercherClient.Text +
                  "%' or [Code Postale Du Client] like '%" + this.txtRechercherClient.Text + "%' ";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        /// <summary>
        /// s il y a des clients sur la grille , le fait de selectioner un client rend le bouton supprimer active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClient.RowCount != 0)
            {
                this.btnSupprimer.Enabled = true;
            } 
        }
        /// <summary>
        /// double clic sur la grille ; ouvrir la feuille détail en y affichant le client correspondant a la ligne double clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdClient.CurrentRow != null)
            {
                Int32 iClient;
                iClient = this.grdClient.CurrentRow.Index;
                Client leClient = Donnees.ArrayClient[iClient];

                frmCLIE frmclient = new frmCLIE(leClient);
                frmclient.ShowDialog();

                this.afficheClient();
            }
            
        }
    }
}
