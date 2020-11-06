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
    public class Patient
    {
        private string _id;
        private string _idPersonne;
        private string __idAgent;
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
                return __idAgent;
            }

            set
            {
                __idAgent = value;
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
            try { 
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "[sp_insert_Patient]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@id", 50, DbType.String, _id));
                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdPersonne", 50, DbType.Int32, _idPersonne));
                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAgent", 50, DbType.Int32, __idAgent));
                cmd.ExecuteNonQuery();
                reponse = true;
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }     

       
       
    }
}
