
using Facture.Fonctions;
using Facture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.Proprietes
{
   public class ProprietePublique
    {
      
        public bool Supprimer(string id,string table)
        {
            bool message = false;
            try { 
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "Delete from " + table + " where Id='" + id + "'";
                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@id", 50, DbType.String, id));
                cmd.ExecuteNonQuery();
                message = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return message;
        }
        public bool Supprimer2(string procedure)
        {
            bool message = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = procedure;
                    cmd.ExecuteNonQuery();
                    message = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return message;
        }
        public string RetournerValueur(string rqt)
        {
            string id = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText =rqt ;

                    IDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                      id = (rd["Valeur"].ToString()) ;
                    }

                    rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }

            return id;
        }
        public string IdMax(string table)
        {
            string id = "";
            try { 
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT  max(Id) as Id from " + table + "";
                IDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    id = rd["Id"].ToString();
                }
                rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return id;
        }
        public decimal Montant(string table, string colone)
        {
            decimal montant = 00;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "select " + colone + " as Val from " + table + "";
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        montant = decimal.Parse(rd["Val"].ToString());                        

                    }
                    rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return montant;
        }
        public string IdCombo(string table, string combo, string colonne1)
        {
            string id = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "Select Id as Id  from " + table + "  where " + colonne1 + "='" + combo + "'";
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        id = rd["Id"].ToString();
                    }
                    rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return id;
        }
        public string IdCombo__(string rqt)
        {
            string id = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = (rqt);
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                       id = rd["Id"].ToString();

                    }
                    rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return id;
        }
      
        public int NbreEnregistrement(string table,string colone)
        {
            int id = 0;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "select "+ colone +" as Id from "+table+"";
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        id = int.Parse(rd["Id"].ToString());
                       
                    }
                    rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return id;
        }
       
        public string  Retourne2val(string table,string champ, string colonne, string colonne1)
        {
            string retour1 = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "select * from " + table + " where "+champ+"='"+colonne+"'";
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        retour1 = rd[colonne1].ToString();
                    }
                    rd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return retour1;
        }
        public string MontantApayer(string patient)
        {
            string montant = "";

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "select sum(Total) as Montant from Apayer where etat=1 and patient='"+patient+"'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {                   
                 montant = rd["Montant"].ToString();                                     
                }
                rd.Dispose();
            }
            return montant;
        }

        public void ChargerCombo(string table, ComboBox combo, string colonne1)
        {
            try { 
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "Select "+colonne1+" as Colonne  from " + table + "";
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    combo.Items.Add( rd["Colonne"].ToString());
                }
                rd.Dispose();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
        }
        public bool SavePhoto(byte[] profil, string Table, string id)
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "Update " + Table + " set Profil=@Profil where Id='" + id + "'";
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Profil",100, DbType.Binary, Int32.MaxValue).Value=profil);
                    cmd.ExecuteNonQuery();
                    reponse = true;
                    cmd.Dispose();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
            return reponse;
        }      
        public void  Autocomplete(string rqt, string colone, TextBox auto)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    IDataReader dr =null;
                    cmd.CommandText = rqt;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        auto.AutoCompleteCustomSource.Add(dr[colone].ToString());
                    }
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    auto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }
        }
        public void Autocomplete(string rqt, string colone, ComboBox auto)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    IDataReader dr = null;
                    cmd.CommandText = rqt;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        auto.AutoCompleteCustomSource.Add(dr[colone].ToString());
                    }
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Close();
            }

        }              

    }


}
