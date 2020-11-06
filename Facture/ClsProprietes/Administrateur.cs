using Facture.Connexion;
using Facture.Fonctions;
using ManagerConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonneLib.Proprietes
{
    public class Administrateur
    {
        private string _id;
        private string _idAgent;
        private string _username;
        private string _pwd;
        private int _niveau;
        private byte[] _profil;

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

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
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

        public byte[] Profil
        {
            get
            {
                return _profil;
            }

            set
            {
                _profil = value;
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

        public bool Enregistrer1()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_insert_Admin";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Nom", 50, DbType.String, _username));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Pwd", 50, DbType.String, _pwd));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Niveau", 50, DbType.String, _niveau));
                    if (_profil != null)
                    {
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Profil", int.MaxValue, DbType.Binary, _profil));
                    }
                    else
                    {
                        MessageBox.Show("Pas de photo svp !!");
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Profil", int.MaxValue, DbType.Binary, null));
                    }
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }
        public bool Enregistrer2()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_insert_User";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAgent", 50, DbType.String, _idAgent));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Nom", 50, DbType.String, _username));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Pwd", 50, DbType.String, _pwd));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Niveau", 50, DbType.String, _niveau));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }
    }
}
