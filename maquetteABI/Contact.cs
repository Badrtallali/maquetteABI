using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquetteABI
{
  public  class Contact
  {
      public static Int32 Ncontact;
        private Int32 numContact;
        private String nomContact;
        private String prenomContact;
        private String telephoneContact;
        private String fonctionContact;
        private String mailcontact;
      public int NumContact
        {
           get
            { return this.numContact; }
          set
            { numContact = value; }
        }

      public string NomContact
      {
          get { return this.nomContact; }
          set { this.nomContact = value.Trim().ToUpper(); }
      }
     
      public string PrenomContact
      {
          get { return this.prenomContact; }
          set { this.prenomContact = value.Trim().ToUpper(); }
      }
      public string TelephoneContact
      {
          get { return telephoneContact; }
          set
          {

              telephoneContact = value;
          }
      }
      public string FonctionContact
      {
          get { return this.fonctionContact; }
          set { fonctionContact = value; }

      }
      public string MailContact
      {
          get { return this.mailcontact; }
          set { mailcontact = value; }
      }


        

    }
}
