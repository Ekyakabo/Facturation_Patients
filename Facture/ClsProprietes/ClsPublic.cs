using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.ClsProprietes
{
   public class ClsPublic
    {
        private string _id;
        private string _nom;
        private string _fonction;
        private string _phone;
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
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
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
