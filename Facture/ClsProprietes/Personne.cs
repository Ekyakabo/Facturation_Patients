using Facture.Fonctions;
using Facture.ClsTraitements;
using Facture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Facture.ClsProprietes
{
    public class Personne 
    {
        public Personne()
        {
        }

        private string  _id;
        private string _nom;
        private string _postnom;
        private string _prenom;
        private string _sex;
        private string _phone;
        private string _mail;
        private string _adresse;
        private string _lieuNaiss;
        private string _dateNaiss;
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

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = ValidateName(value);
            }
        }

        private string ValidateName(string nom)
        {
            if (!string.IsNullOrEmpty(nom))
            {
                if (!char.IsLetter(nom[0]))
                    throw new InvalidOperationException("Name must begin with letter !!!");
                else
                {
                    nom = nom.ToLower();
                    return nom[0].ToString().ToUpper() + new string(nom.ToCharArray(), 1, nom.Length - 1);
                }

            }
            else
                throw new InvalidOperationException("Name must have value !!!");
        }

        public string Postnom
        {
            get
            {
                return _postnom;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _postnom = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _prenom = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _prenom = value;
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }       

        public string NomComplet
        {
            get
            {
                return (_nom + " " + (string.IsNullOrEmpty(_postnom) ? "" : _postnom + " ") + _prenom).Trim();
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _adresse;
            }

            set
            {
                _adresse = value;
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

        public string LieuNaiss
        {
            get
            {
                return _lieuNaiss;
            }

            set
            {
                _lieuNaiss = value;
            }
        }

        public string DateNaiss
        {
            get
            {
                return _dateNaiss;
            }

            set
            {
                _dateNaiss = value;
            }
        }

        public void SavePhoto(byte[] profil, string Table, string code)
        {
            try
            {
                DynamicClass d = new DynamicClass();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {                    
                    d.con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                    cmd.CommandText = "update " + Table + " set Profil= @photo where Code='" + code + "'";
                    if (_profil != null)
                    {
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "photo", int.MaxValue, DbType.Binary, _profil));
                    }
                    else
                    {
                        MessageBox.Show("Pas de photo svp !!");
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "photo", int.MaxValue, DbType.Binary, null));
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    cmd.CommandText = "sp_insert_Personne";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Nom", 50, DbType.String, _nom));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Postnom", 50, DbType.String, _postnom));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Prenom", 50, DbType.String, _prenom));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Sexe", 1, DbType.String, _sex));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@LieuNaiss", 50, DbType.String, _lieuNaiss));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@DateNaiss", 10, DbType.Date, _dateNaiss));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Phone", 50, DbType.String, _phone));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAdresse", 50, DbType.String, _adresse));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return reponse;
        }
      
        public void Supprimer(string id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_delete_personne";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }        

        public override string ToString()
        {
            return (_nom + " " + (string.IsNullOrEmpty(_postnom) ? "" : _postnom + " ") + _prenom).Trim();
        }
    }
}
