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
    public partial class frmContact : Form
    {

        private Contact contact;

        public frmContact(ref Contact contact)
        {
            this.contact = contact;
            InitializeComponent();
        }

       

        private void btnFermerContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

       

        private void btnModifierContact_Click(object sender, EventArgs e)
        {

            if (this.controle())
            {
                //for (int i = 0; i < Donnees.ArrayContact.Count; i++)
                //{
                //    if (Int32.Parse(txtNumContact.Text.Trim()) == Donnees.ArrayClient[i].NumClient)
                //    {
                //        Donnees.ArrayClient.Remove(Donnees.ArrayClient[i]);
                //    }
                //}



                //Contact ContactModiff = new Contact();

                contact.NomContact = txtNomContact.Text.Trim().ToUpper();
                contact.PrenomContact = txtPrenomContact.Text.Trim().ToUpper();
                contact.FonctionContact = txtFonctionContact.Text;
                contact.MailContact = txtAdresseMailContact.Text;
                contact.TelephoneContact = txtTelephoneContact.Text;
               

                //Donnees.ArrayContact.Add(ContactModiff);
                this.DialogResult = DialogResult.OK;



            }
        }

        private void Liste_Contactes_Load(object sender, EventArgs e)
        {
            this.afficheContact(contact);
        }

        private void afficheContact(Contact unContact)
        {
            this.txtNumContact.Text = unContact.NumContact.ToString();
            this.txtNomContact.Text = unContact.NomContact.Trim().ToUpper();
            this.txtPrenomContact.Text = unContact.PrenomContact.Trim().ToUpper();
            this.txtFonctionContact.Text = unContact.FonctionContact;
            this.txtAdresseMailContact.Text = unContact.MailContact;
            this.txtTelephoneContact.Text = unContact.TelephoneContact.ToString();
          
        }






        public Boolean controle()
        {
            Boolean code = true;
            if (!(Outils.EstEntier(this.txtNumContact.Text)))
            {
                code = false;
                MessageBox.Show("Le numero de contact saisi n'est pas un entier valide", "Erreur", MessageBoxButtons.OK);
            }
            //for (int i = 0; i < Donnees.ArrayContact.Count; i++)
            //{
            //    if (!(Int32.Parse(txtNumContact.Text.Trim()) == Donnees.ArrayContact[i].NumContact))
            //        code = true;
            //    else
            //    {
            //        code = false;
            //        MessageBox.Show("le numero de Contact est deja atibuer", "Erreur", MessageBoxButtons.OK);
            //    }
            //}
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
