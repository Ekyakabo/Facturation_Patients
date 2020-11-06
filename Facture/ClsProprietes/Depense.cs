using Facture.Connexion;
using Facture.Fonctions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.ClsProprietes
{
   public  class Depense
    {
        private string _id;
        private string _idAgent;
        private decimal _montant;
        private string _motif;

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

        public decimal Montant
        {
            get
            {
                return _montant;
            }

            set
            {
                _montant = value;
            }
        }

        public string Motif
        {
            get
            {
                return _motif;
            }

            set
            {
                _motif = value;
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
                    cmd.CommandText = "Sp_Insert_Depense";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Motif", 50, DbType.String, _motif));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Montant", 50, DbType.Decimal, Montant));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAgent", 50, DbType.Int32, _idAgent));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { ImplementeConnexion.Instance.Conn.Close(); }
            return reponse;
        }
    }
}
