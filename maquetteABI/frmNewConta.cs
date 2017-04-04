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
    public partial class frmNewConta : Form
    {
        private Client client;
        public frmNewConta(Client client)
        {
            InitializeComponent();
            this.client = client;
        }
        /// <summary>
        /// bouton ignorer ferme la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIgnorerContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }       
        /// <summary>
        /// si tout control est ok  on instancie un nouveau contact et on incremente le nombre des contact dans la liste des contact client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderContact_Click(object sender, EventArgs e)
        {
            if (this.controle())
            {
                if (this.instancie())
                {
                    Contact.Ncontact+= 1;

                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        /// <summary>
        /// instancier un client 
        /// </summary>
        /// <returns></returns>
        private Boolean instancie()
        {
            Contact nouveauContact = new Contact();
            try
            {
                nouveauContact.NumContact = Int32.Parse(txtNumContact.Text.Trim());
                nouveauContact.NomContact = txtNomContact.Text.Trim().ToUpper();
                nouveauContact.PrenomContact = txtPrenomContact.Text.Trim().ToUpper();
                nouveauContact.FonctionContact = txtFonctionContact.Text;
                nouveauContact.TelephoneContact = txtTelephoneContact.Text;
                nouveauContact.MailContact = txtAdresseMailContact.Text;

                client.ListeContactClient.Add(nouveauContact);
                return true;
            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de Contact");
                return false;
            }

        }

        /// <summary>
        /// methode pour gerer les exceptions 
        /// </summary>
        /// <returns></returns>
        public Boolean controle()
        {
            Boolean code = true;
            if (!(Outils.EstEntier(this.txtNumContact.Text)))
            {
                code = false;
                MessageBox.Show("Le numero de contact saisi n'est pas un entier valide", "Erreur", MessageBoxButtons.OK);
            }
            for (int i = 0; i < client.ListeContactClient.Count; i++)
            {
                if (!(Int32.Parse(txtNumContact.Text.Trim()) == client.ListeContactClient[i].NumContact))
                    code = true;
                else
                {
                    code = false;
                    MessageBox.Show("le numero de Contact est deja atibuer", "Erreur", MessageBoxButtons.OK);
                }
            }
            if (!(Outils.EstEntier(this.txtTelephoneContact.Text)))
            {
                code = false;
                MessageBox.Show("Le numero de telephone  saisi n'est pas correct", "Erreur", MessageBoxButtons.OK);
            }


            if (this.txtNomContact.Text == "")
            {
                code = false;
                MessageBox.Show("veullez indiquer un nom au contact", "Erreur", MessageBoxButtons.OK);
            }
            
            return code;
        }
    }
}
