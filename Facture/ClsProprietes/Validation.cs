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
    public class Validation
    {
        private string _id;
        private string _idFac;
        private string _idAgent;
        private string _idDep;
        private string _choix;

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

        public string IdFac
        {
            get
            {
                return _idFac;
            }

            set
            {
                _idFac = value;
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

        public string IdDep
        {
            get
            {
                return _idDep;
            }

            set
            {
                _idDep = value;
            }
        }

        public string Choix
        {
            get
            {
                return _choix;
            }

            set
            {
                _choix = value;
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
                    cmd.CommandText = "sp_insert_validation";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdFac", 50, DbType.Int32, _idFac));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdDep", 50, DbType.Int32, _idDep));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdUser", 50, DbType.Int32, _idAgent));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@choix", 50, DbType.Int32, _choix));

                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }
    }
}
