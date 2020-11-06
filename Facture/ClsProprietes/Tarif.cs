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
   public  class Tarif
    {
        private string _id;
        private string _designation;
        private decimal _montant;

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

        public string Designation
        {
            get
            {
                return _designation;
            }

            set
            {
                _designation = value;
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
        public bool Enregistrer()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_insert_Tarif";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Designation", 50, DbType.String, _designation));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Montant", 50, DbType.Decimal, _montant));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;

        }
    }
}
