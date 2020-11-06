using Facture.Fonctions;
using Facture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.ClsProprietes
{
   public class Agent
    {
        private string _id;
        private string _fonction;
        private string _idPersonne;

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

        public string IdPersonne
        {
            get
            {
                return _idPersonne;
            }

            set
            {
                _idPersonne = value;
            }
        }
        public bool Enregistrer()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_insert_Agent";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Fonction", 50, DbType.String, _fonction));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdPersonne", 50, DbType.String,_idPersonne ));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
            return reponse;
        }      
     

    }
}
