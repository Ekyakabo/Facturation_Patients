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
    public class Examen
    {
        private string _id;
        private string _idAgent;
        private string _idPatient;
        private string _idConsultation;
        private string _resultat;
        private string _idtarif;

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

        public string IdPatient
        {
            get
            {
                return _idPatient;
            }

            set
            {
                _idPatient = value;
            }
        }

        public string IdConsultation
        {
            get
            {
                return _idConsultation;
            }

            set
            {
                _idConsultation = value;
            }
        }

        public string Resultat
        {
            get
            {
                return _resultat;
            }

            set
            {
                _resultat = value;
            }
        }

        public string Idtarif
        {
            get
            {
                return _idtarif;
            }

            set
            {
                _idtarif = value;
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
                    cmd.CommandText = "sp_insert_Resultat";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdDetail", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdPatient", 50, DbType.Int32, _idPatient));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAgent", 50, DbType.Int32, _idAgent));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Resultat", 50, DbType.String, _resultat));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@idconsultation", 50, DbType.String, IdConsultation));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Tarif", 50, DbType.Int32, _idtarif));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }
    }
}
