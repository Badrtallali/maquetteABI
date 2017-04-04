using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquetteABI
{
    public class Client
    {
        private Int32 numClient;
        private String raisoClient;
        private String adresClient;
        private String telephoneClient;
        private String domaineClient;
        private String typClient;
        private String villeClient;
        private String codePostalClient;
        public static  Int32 Nclient;
        private String natClient;
        private Double chiffClient;
        private String effeClient;
        private List<Contact> listeContactClient = new List<Contact>();
        private String commentClient;

        public int NumClient
        {
            get
            { return numClient; }
            set
            { numClient = value; }
        }

      
        public string RaisoClient
        {
            get { return this.raisoClient; }
            set { raisoClient = value; }
        }
        public string AdresClient
        {
            get { return adresClient; }
            set { adresClient = value; }
        }
        public string VilleClient
        {
            get { return villeClient; }
            set { villeClient = value.Trim().ToUpper(); }
        }


        public string CodePostalClient
        {
            get
            {
                return codePostalClient;
            }

            set
            {
                codePostalClient = value;
               
            }
        }
        public string TelephoneClient
        {
            get { return telephoneClient; }
            set
            {
                telephoneClient = value;
            }
        }
        public string DomaineClient
        {
            get { return domaineClient; }
            set { domaineClient = value; }
        }
        public string TypClient
        {
            get { return typClient; }
            set { typClient = value; }
        }
        public string NatClient
        {
            get
            { return natClient; }
            set { natClient = value; }
        }
        public double ChiffClient
        {
            get { return chiffClient; }
            set { chiffClient = value; }
        }
        public string EffeClient
        {
            get { return effeClient; }
            set
            {
                effeClient = value;
            }
        }

        public List<Contact> ListeContactClient
        {
            get
            {
                return listeContactClient;
            }

            set
            {
                listeContactClient = value;
            }
        }

        public  string CommentClient
        {
            get { return commentClient; }
            set { commentClient = value; }

        }
           
            


    }
}
