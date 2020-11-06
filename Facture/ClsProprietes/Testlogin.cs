using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.ClsProprietes
{
   public class Testlogin
    {
        private string _id;
        private string _nomUser;
        private int _niveau;
        private string _fonction;
        private string _phone;
        public string NomUser
        {
            get
            {
                return _nomUser;
            }

            set
            {
                _nomUser = value;
            }
        }

        public int Niveau
        {
            get
            {
                return _niveau;
            }

            set
            {
                _niveau = value;
            }
        }

        public string Fonction
        {
            get
            {
                return _fonction;
            }

            set
            {
                _fonction = value;
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
    }
}
