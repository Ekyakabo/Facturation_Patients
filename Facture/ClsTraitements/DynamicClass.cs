using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facture.Proprietes;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Facture.Connexion;
using Facture.Fonctions;
using Facture.ClsProprietes;

namespace Facture.ClsTraitements
{
   public class DynamicClass
    {
        public static DynamicClass _intance = null;
        public SqlCommand sql = null;
        MySqlCommand mysql = null;
        public SqlConnection con;
        public MySqlConnection conn;
        public IDataAdapter dt = null;
        public  IDataReader dr = null;
        public DataSet ds=null;
        public SqlDataAdapter dap=null;

        public static DynamicClass GetInstance()
        {
            if (_intance == null)
                _intance = new DynamicClass();
            return _intance;
        }
        private string _serveur = "";
        public string Serveur
        {
            get
            {
                return _serveur;
            }
            set
            {
                _serveur = value;
            }
        }       

        public DataTable GetTableUsingSql(string nomTable)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                sql = new SqlCommand("SELECT * FROM " + nomTable + "", con);
                dt = null;
                dt = new SqlDataAdapter(sql);
                ds = new DataSet();
                dt.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return ds.Tables[0];
        }
        public DataTable GetTableUsingSqlOptimise(string reqte)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                sql = new SqlCommand(reqte, con);
                dt = null;
                dt = new SqlDataAdapter(sql);
                ds = new DataSet();
                dt.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return ds.Tables[0];
        }
        public DataSet Selection_Date_oper(string table)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                sql = new SqlCommand("SELECT * FROM " + table + "", con);
                dt = null;
                dt = new SqlDataAdapter(sql);
                ds = new DataSet();
                dt.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return ds;
        }
    public void Graphique(Chart chart1,string serie,string rqt,string x,string y)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = rqt;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        // chart1.Series[serie].Points.AddY(x, dr[y].ToString());
                        chart1.Series[serie].Points.AddY(dr[y]);
                       // chart1.Series[serie].Points.add(dr[y]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
        }
        public DataTable GetTableUsingMysql(string nomTable)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                conn = (MySqlConnection)ImplementeConnexion.Instance.Conn;
                mysql = new MySqlCommand("SELECT * FROM " + nomTable + "", conn);
                dt = null;
                dt = new MySqlDataAdapter(mysql);
                ds = new DataSet();
                dt.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds.Tables[0];
        }
        public DataSet Liste_Rapport(string requete)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                sql = new SqlCommand(requete,con);
                dap = null;
                dap = new SqlDataAdapter(sql);
                ds = new DataSet();
                dap.Fill(ds);
                ImplementeConnexion.Instance.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { ImplementeConnexion.Instance.Conn.Close(); }
            return ds;
        }
        
        public void Barecode()
        {
        }
        public void RetournerPhotoSQl(string ChampPhoto, string nomTable, string ChampCode, string Valeur, PictureBox pic)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT " + ChampPhoto + " from " + nomTable + " WHERE  " + ChampCode + " = '" + Valeur + "'";
                    dt = new SqlDataAdapter((SqlCommand)cmd);
                    Object resultat = cmd.ExecuteScalar();
                    if (DBNull.Value == (resultat))
                    {
                    }
                    else
                    {
                        Byte[] buffer = (Byte[])resultat;
                        MemoryStream ms = new MemoryStream(buffer);
                        Image image = Image.FromStream(ms);
                        pic.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        public void RetournerPhotoMySQL(string ChampPhoto, string nomTable, string ChampCode, string Valeur, PictureBox pic)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT " + ChampPhoto + " from " + nomTable + " WHERE  " + ChampCode + " = '" + Valeur + "'";
                    dt = new MySqlDataAdapter((MySqlCommand)cmd);
                    Object resultat = cmd.ExecuteScalar();
                    if (DBNull.Value == (resultat))
                    {

                    }
                    else
                    {
                        Byte[] buffer = (Byte[])resultat;
                        MemoryStream ms = new MemoryStream(buffer);
                        Image image = Image.FromStream(ms);
                        pic.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        public void RetourPhoto(string txtserveur,string idagent,PictureBox profil)
        {
            try
            {
                switch (txtserveur)
                {
                    case "SQLServeur":
                        RetournerPhotoSQl("Profil", "tabagent", "Id", idagent, profil); break;
                    case "MySQL":
                        RetournerPhotoMySQL("Profil", "tabagent", "Id", idagent, profil); break;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public byte[] convertImageTobyte(PictureBox pic)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(pic.Image);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }       
        public DataTable recherche_UsignSql(string query )
        {
            try { 
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            con = (SqlConnection)ImplementeConnexion.Instance.Conn;
            sql = new SqlCommand(query, con);
            dt = null;
            dt = new SqlDataAdapter(sql);
            ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return ds.Tables[0];
        }
        public DataTable recherche_UsingMysql(string query)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                conn = (MySqlConnection)ImplementeConnexion.Instance.Conn;
                mysql = new MySqlCommand(query, conn);
                dt = null;
                dt = new MySqlDataAdapter(mysql);
                ds = new DataSet();
                dt.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds.Tables[0];
        }
        public void Recherche(string serveur,string rqt)
        {
            switch(serveur)
            {
                case "SQL": recherche_UsignSql(rqt); break;
                case "MySQL": recherche_UsingMysql(rqt); break;
            }
        }       
        public bool loginTest(string nom, string password , Testlogin log)
        {
            bool reponse= false;            
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    //cmd.CommandText = "select * from Connexion where NomUser= @NomUser  and MotDePasse=@MotDePasse";
                    cmd.CommandText = "SP_Login";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, nom));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@pass", 50, DbType.String, password));
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        log.Id = dr["Id"].ToString();
                        log.Niveau = int.Parse(dr["Niveau"].ToString());
                        log.NomUser = dr["Username"].ToString();                        
                        log.Fonction = dr["Fonction"].ToString();
                        log.Phone = dr["Phone"].ToString();
                        reponse = true;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
            return reponse;
        }
        public bool  AproposPresence(string id,ClsPublic p)
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "select * from tabagent where Id=@Id";
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, id));
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        p.Nom = dr["Nom"].ToString();
                        p.Fonction =dr["Fonction"].ToString();
                        p.Phone = dr["Phone"].ToString();
                        reponse = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
            return reponse;
        }
        public bool loginTest2(string nom, string password, Testlogin log)
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Login";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, nom));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@pass", 50, DbType.String, password));
                    mysql = (MySqlCommand)cmd;
                    dr = mysql.ExecuteReader();
                    while (dr.Read())
                    {
                        log.Id = dr["Id"].ToString();
                        log.Niveau = int.Parse(dr["Niveau"].ToString());
                        log.NomUser = dr["NomAgent"].ToString();
                        log.Fonction = dr["Fonction"].ToString();
                        //  log.Phone = dr["Phone"].ToString();
                        reponse = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
            return reponse;
        }
      
        public string BarreCode(string rqt,string recherche, string barcode )
        {
            string resultat = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = rqt;
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    while (dr.Read())
                    {
                        resultat = (dr["Valeur"].ToString());
                        if (barcode != "")
                        {
                            barcode = "";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                dr.Close();
            }
            return resultat;
        }
        /*
        public void ChargerChat(string rqt,Chart chart1, string colonne, string colonne1)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = rqt;
                    IDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                        while (dr.Read())
                        {
                            chart1.Series["s1"].Points.AddY(dr[colonne].ToString(), dr[colonne1].ToString());
                        }
                }               
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }

        }
        */
    }
}
