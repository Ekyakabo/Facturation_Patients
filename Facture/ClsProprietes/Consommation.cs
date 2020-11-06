using Facture.Connexion;
using Facture.Fonctions;
using Facture.Proprietes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.ClsProprietes
{
  public   class Consommation
    {
        private string _id;
        private string _idMedicament;
        private string _idAgent;
        private string _idPatient;
        ProprietePublique pro = new ProprietePublique();
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
        public string IdMedicament
        {
            get
            {
                return _idMedicament;
            }

            set
            {
                _idMedicament = value;
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
        public bool Entete()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "Sp_InsertEnteteConsommation";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdEntete", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdPatient", 50, DbType.Int32, _idPatient));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAgent", 50, DbType.Int32, _idAgent));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { ImplementeConnexion.Instance.Conn.Close(); }
            return reponse;
        }
        public bool Enregistrer(DataGridView data)
        {
            bool reponse = false;
            string enteteId = pro.IdMax("EnteteMedicament");
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    int i = 0;
                    for (int x = 0; x < data.Rows.Count - 1; x++)
                    {
                        string Identete = enteteId;
                        string a = data.Rows[x].Cells[0].Value.ToString();
                        int b = int.Parse(data.Rows[x].Cells[3].Value.ToString());
                        int c = int.Parse(data.Rows[x].Cells[2].Value.ToString());
                        cmd.CommandText = "Exec sp_insert_DetailConsommation  '" + Identete + "','" + a + "','"+b+"','"+c+"'";
                        cmd.ExecuteNonQuery();
                        reponse = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { ImplementeConnexion.Instance.Conn.Close(); }
            return reponse;
        }

    }
}
