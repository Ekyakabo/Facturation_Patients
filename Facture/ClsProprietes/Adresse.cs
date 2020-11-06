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
    public class Adresse
    {
        private string _id;
        private string _pays;
        private string _province;
        private string _Ville;
        private string _commune;
        private string _quartier;
        private string _Avenue;
        private string _numero;
        private string _modifier;
        private string _supprimerId;

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
        public string Ville
        {
            get
            {
                return _Ville;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _Ville = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _Ville = value;
            }
        }
        public string Commune
        {
            get
            {
                return _commune;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _commune = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _commune = value;
            }
        }
        public string Quartier
        {
            get
            {
                return _quartier;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _quartier = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _quartier = value;            
            }
        }

        public string Avenue
        {
            get
            {
                return _Avenue;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _Avenue = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _Avenue = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _numero = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _numero = value;
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
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _modifier = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                _modifier = value;
            }
        }

        public string SupprimerId
        {
            get
            {
                return _supprimerId;
            }

            set
            {
                _supprimerId = value;
            }
        }

        public string Pays
        {
            get
            {
                return _pays;
            }

            set
            {
                _pays = value;
            }
        }

        public string Province
        {
            get
            {
                return _province;
            }

            set
            {
                _province = value;
            }
        }

        public int Nouveau()
        {
            int id = 0;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "select max(id) as lastId from TabAdresse";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        id = 1;
                    else
                        id = Convert.ToInt32(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }

            return id;
        }
        public bool  Enregistrer()
        {
            bool reponse = false;
            try {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_insert_Adresse";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Pays", 50, DbType.String, _pays));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Province", 50, DbType.String, _province));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Ville", 50, DbType.String, _Ville));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Commune", 50, DbType.String, _commune));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Quartier", 50, DbType.String, _quartier));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Avenue", 50, DbType.String, _Avenue));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Numero", 50, DbType.String, _numero));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;

        }
      
        public void Supprimer(string id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_delete_Adresse";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.String, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        
    }
}
