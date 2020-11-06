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
    public class Approvision
    {
        private string _id;
        private string _idMedicament;
        private string _idAgent;
       
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
        public bool Entete()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "Sp_InsertEnteteApprovision";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
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
            string enteteId = pro.IdMax("EnteteApprovision");
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
                        DateTime b = DateTime.Parse(data.Rows[x].Cells[2].Value.ToString());
                        DateTime c =DateTime.Parse( data.Rows[x].Cells[3].Value.ToString());
                        int d = int.Parse(data.Rows[x].Cells[4].Value.ToString());
                        float e = float.Parse(data.Rows[x].Cells[5].Value.ToString());                      

                        cmd.CommandText = "Exec sp_insert_DetailAppro  '"+ Identete + "','" + a + "','" + b.ToString("yyyy-MM-dd") + "','" + c.ToString("yyyy-MM-dd") + "','" + d + "','"+e+"'";
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
