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
    public partial class frmCLIE : Form
    {

        private Client LeClient;
        public frmCLIE(Client unClient)
        {
            this.LeClient = unClient;

            InitializeComponent();


        }


        private void frmCLIE_Load(object sender, EventArgs e)
        {
            cbxNatureClient.Items.AddRange(new String[] { "principale", "secondaire", "ancienne" });
            cbxTypeClient.Items.AddRange(new String[] { "public", "privee" });
            this.afficheClient(LeClient);
        }
        private void afficheClient(Client unClient)
        {
            this.txtNumeroDeClient.Text = unClient.NumClient.ToString();
            this.txtRaisonSocialeDuClient.Text = unClient.RaisoClient;
            this.txtDomaineDactivite.Text = unClient.DomaineClient;
            this.txtAdresseDuClient.Text = unClient.AdresClient;
            this.txtVille.Text = unClient.VilleClient;
            this.txtCodePostale.Text = unClient.CodePostalClient.ToString();
            this.txtTelephone.Text = unClient.TelephoneClient.ToString();
            this.txtChiffreDaffaire.Text = unClient.ChiffClient.ToString();
            this.txtEffectifs.Text = unClient.EffeClient.ToString();
            this.cbxNatureClient.Text = unClient.NatClient;
            this.cbxTypeClient.Text = unClient.TypClient;
            this.txtCommentClient.Text = unClient.CommentClient;
            this.txtNumeroDeClient.Enabled = false;
        }


        private void btnFermerClient_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        private void btnContactClient_Click(object sender, EventArgs e)
        {
            frmgrdCONTA frmcontact = new frmgrdCONTA(LeClient);
            DialogResult rep = frmcontact.ShowDialog();

        }



        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtNumeroDeClient.Text);
            
        
            if (this.controle())
            {
                for (int i = 0; i < Donnees.ArrayClient.Count; i++)
                {
                    if (Int32.Parse(txtNumeroDeClient.Text.Trim()) == Donnees.ArrayClient[i].NumClient)
                    {
                        Donnees.ArrayClient.Remove(Donnees.ArrayClient[i]);
                    }
                }
                


                    Client ClientModif = new Client();
                ClientModif.NumClient = a;
                ClientModif.RaisoClient = txtRaisonSocialeDuClient.Text;
                ClientModif.DomaineClient = txtDomaineDactivite.Text;
                ClientModif.AdresClient = txtAdresseDuClient.Text;
                ClientModif.VilleClient = txtVille.Text;
                ClientModif.TelephoneClient = txtTelephone.Text;
                ClientModif.ChiffClient = Double.Parse(txtChiffreDaffaire.Text.Trim());
                ClientModif.CodePostalClient = txtCodePostale.Text;
                ClientModif.EffeClient = txtEffectifs.Text;
                ClientModif.NatClient = cbxNatureClient.Text;
                ClientModif.TypClient = cbxTypeClient.Text;
                ClientModif.CommentClient = txtCommentClient.Text;

                Donnees.ArrayClient.Add(ClientModif);
                this.DialogResult = DialogResult.Cancel;



            }




        }

        public Boolean controle()
        {
            Boolean code = true;


            if (this.txtRaisonSocialeDuClient.Text == "")
            {
                code = false;
                MessageBox.Show("veullez indiquer une raison sociale", "Erreur", MessageBoxButtons.OK);
            }

            if (!(Outils.EstEntier(this.txtNumeroDeClient.Text)))
            {
                code = false;
                MessageBox.Show("Le numero de client saisi n'est pas un entier valide", "Erreur", MessageBoxButtons.OK);
            }
        
            if (!(Outils.EstEntier(this.txtCodePostale.Text)) || this.txtCodePostale.Text.Length != 5)
            {
                code = false;
                MessageBox.Show("Le code postal saisi n'est pas correct", "Erreur", MessageBoxButtons.OK);
            }

            if (!(Outils.EstEntier(this.txtTelephone.Text)))
            {
                code = false;
                MessageBox.Show("le numero de telephone saisi n'est pas un entier valide", "Erreur", MessageBoxButtons.OK);
            }

            if (!(Outils.EstEntier(this.txtEffectifs.Text)))
            {
                code = false;
                MessageBox.Show("l'Effectifs saisi n'est pas un entier valide", "Erreur", MessageBoxButtons.OK);
            }
            Double ca;
            if (!Double.TryParse(txtChiffreDaffaire.Text, out ca))
            {
                code = false;
                MessageBox.Show("CA must be a double", "Erreur", MessageBoxButtons.OK);
            }
            return code;
        }

        private void grbClient_Enter(object sender, EventArgs e)
        {


        }
    }
}

