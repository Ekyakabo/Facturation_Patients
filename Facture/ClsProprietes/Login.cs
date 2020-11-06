
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.ClsProprietes
{
  public   class Login
    {
        private string _id;
        private string _nomUser;
        private string _motDepasse;
        private int _niveau;
        private string _idAgent;
        private string _modifier;
        private string _supprimer;

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

        public string MotDepasse
        {
            get
            {
                return _motDepasse;
            }

            set
            {
                _motDepasse = value;
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

        public string IdAgent
        {
            get
            {
                return _idAgent;
            }

            set
            {
                _idAgent = value;
            }
        }

        public string Modifier
        {
            get
            {
                return _modifier;
            }

            set
            {
                _modifier = value;
            }
        }

        public string Supprimer
        {
            get
            {
                return _supprimer;
            }

            set
            {
                _supprimer = value;
            }
        }
    
    }
}
