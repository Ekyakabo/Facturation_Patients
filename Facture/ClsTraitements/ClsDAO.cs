using Facture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.ClsTraitements
{
    class ClsDAO
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public IDataReader dr = null;
        //public SqlDataAdapter datApt;
        public DataSet daset = null;
        public SqlDataAdapter dp;
        public DataSet dst = null;
        ClsConnexion cnx = new ClsConnexion();
        static ClsDAO dao;
        public static ClsDAO GetInstance()
        {
            if (dao == null)
                dao = new ClsDAO();
            return dao;
        }
        public void InitialiserConnexion()
        {
            try
            {
                cnx.connect();
                conn = new SqlConnection(cnx.chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Executer(string rqt)
        {
            bool test = false;
            try
            {

                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = (rqt);
                cmd.ExecuteNonQuery();
                //fx.Messages(1);
                test = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return test;

        }
        public bool Execute(string rqt)
        {
            bool test = false;
            try
            {

                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = (rqt);
                cmd.ExecuteNonQuery();
                test = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return test;

        }

        public string IdCombo(string table, string id, string combo, string colonne1)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + combo + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr[id].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;
        }
        public int IdCombo_avec_Integer(string table, string id, string combo, string colonne1)
        {
            int code = 0;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + combo + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = int.Parse(dr[id].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;
        }
        public string Barcode(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from agent where code='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["nom_complet"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Fonction(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from v_agent where code='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["Fonction"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }


        public string MaxId(string table)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT  coalesce(max(Code),'') as Id from " + table + " ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string MaxCode(string table)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT  coalesce(max(Code), 0) + 1 as Id from classes", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string chargerNombre(string table, string colonne)
        {
            string id = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT " + colonne + " as nbr from " + table + "", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["nbr"].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return id;
        }
        public string Countnombre(string rqt, string colonne)
        {
            string id = null;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr[colonne].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return id;
        }
        public string nombre(string rqt, string colonne)
        {
            string id = null;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr[colonne].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return id;
        }

        public string nom_utili(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[Nomutilisateur]('" + nom + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string ReturnMouvement(string codes)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[ReturnMouvement]('" + codes + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }


        public string BarcodeAgent(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select barcode from agent where nom_complet='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["barcode"].ToString());

                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string Retouragent(string barcode)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[RetourSortie]('" + barcode + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string code_utili(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[Codeutilisateur]('" + nom + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string Lettre(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select * from OPERATION where code='" + nom + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Toutelettre"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string Adddate(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select * from OPERATION where code='" + nom + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Adddate"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public int RetournerInt(string sql, string colone)
        {
            int code = 0;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = int.Parse(dr[colone].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string RetournerString(string sql, string colone)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = dr[colone].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        //public void chargerChat(string table, Chart chart1, string colonne, string colonne1)
        //{
        //    try
        //    {
        //        InitialiserConnexion();
        //        conn.Open();
        //        cmd = new SqlCommand("SELECT * from " + table + "", conn);
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            chart1.Series["s1"].Points.AddY(dr[colonne].ToString(), dr[colonne1].ToString());
        //        }
        //        cmd.Dispose();
        //        conn.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        conn.Close();

        //    }

        //}
        public void RechercheGrid(string rqt, DataGridView table)
        {
            try
            {
                InitialiserConnexion();
                conn.Open();
                SqlDataAdapter n = new SqlDataAdapter(rqt, conn);
                DataTable v = new DataTable();
                n.Fill(v);
                table.DataSource = v;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificationPhoto(byte[] profil, string Table, string code)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("update " + Table + " set Profil= @photo where Code='" + code + "'", conn);
                cmd.Parameters.Add("@Photo", SqlDbType.Binary, Int32.MaxValue).Value = profil;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
        }
        public void chargementGridOptimise(string sql, DataGridView grid)
        {
            try
            {
                InitialiserConnexion();
                conn.Open();
                SqlDataAdapter n = new SqlDataAdapter(sql, conn);
                System.Data.DataTable v = new DataTable();
                n.Fill(v);
                grid.DataSource = v;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void liste_acces(Label code)
        {
            ListBox lis = new ListBox();
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                {
                    cmd = new SqlCommand("select * from v_utilisateur where code='", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        for (int x = 0; x < lis.Items.Count - 1; x++)
                        {
                            lis.Items.Add(dr["menu"].ToString());
                        }
                    }
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void Autocomplete(string rqt, string colone, TextBox auto)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.AutoCompleteCustomSource.Add(dr[colone].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }
        public void chargerCombo(string rqt, string colonne, ComboBox combo)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    combo.Items.Add(dr[colonne].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }
        public void chargerlist(string rqt, string colonne, ListBox combo)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    combo.Items.Add(dr[colonne].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }


        private void SetParametre(IDbCommand cmd, string name, DbType type, int length, object valeurname)
        {
            //Déclaration et la création de l'objet parametre sur l'objet commande
            IDbDataParameter param = cmd.CreateParameter();
            //Affectation du nom de parametre sur la variable parametre créée
            param.ParameterName = name;
            //Affectation de la longueur du parametre
            param.Size = length;
            //Affectation de type de données au parametre créé
            param.DbType = type;
            if (valeurname == null)
            {
                param.DbType = DbType.String;
                param.Value = DBNull.Value;
            }
            else
                param.Value = valeurname;
            cmd.Parameters.Add(param);
        }
        public string Motif(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select motif from mouvement where code_agent='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["motif"].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string CodeUtilisateur()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.code_utilisateur() as Id ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;
        }
        public string Admin()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[Admin]() as adm ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["adm"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;
        }
        public string BarcodeCode(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select code from Agent where Barcode='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string CodeConcenc(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from [V_Concencration] where Serviteur='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["Serviteur"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string BarcodeFonction(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from [Liste_Agent] where code='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["designation"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Recherchefonction(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from fonction where designation='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["designation"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Menu(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from menu where designation='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["designation"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Menu_Code(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from menu where designation='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }

        public string fonction(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from fonction where designation='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Code_user(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from utilisateur where nom_utilisateur='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Code_valide(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from v_utilisateur where nom_utilisateur='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code_valid"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Nom_user(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from utilisateur where nom_utilisateur='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["nom_utilisateur"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Niveau_user(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from v_utilisateur where nom_utilisateur='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["niveau"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string fonction_user(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from v_utilisateur where nom_utilisateur='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["fonction"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Agent_user(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from v_utilisateur where NOM_UTILISATEUR='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["Agent"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Date_user(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from v_utilisateur where NOM_UTILISATEUR='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["DATE_EXP"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Ministere(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from ministere where designation='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["designation"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string CodeMinistere(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from ministere where designation='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string codecellule(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from cellule where nom_cellule='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string AdresseCellule(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from cellule where nom_cellule='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["adresse"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public string Nom_cellule(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select * from cellule where nom_cellule='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["nom_cellule"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
            rech = "";
        }
        public void Photo(string table, string id, PictureBox pict)
        {
            try
            {
                InitialiserConnexion();
                cmd = new SqlCommand("select photo from " + table + " where Code='" + id + "'", conn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Byte[] dat = new Byte[0];
                    dat = (Byte[])(ds.Tables[0].Rows[0]["photo"]);
                    MemoryStream men = new MemoryStream(dat);
                    pict.Image = System.Drawing.Image.FromStream(men);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void Photos(PictureBox pict, string table, string nom)
        {
            try
            {
                InitialiserConnexion();
                cmd = new SqlCommand("select PHOTO from " + table + " where NOM_COMPLET = '" + nom + "'", conn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Byte[] dat = new Byte[0];
                    dat = (Byte[])(ds.Tables[0].Rows[0]["photo"]);
                    MemoryStream men = new MemoryStream(dat);
                    pict.Image = System.Drawing.Image.FromStream(men);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public string RetourneEntreprise(int la)
        {
            string Nom = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select Nom_entreprise as nom from Entreprise where code_entreprise='" + la + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nom = (dr["nom"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return Nom;
        }
       
        public DataSet liste(string requete)
        {
           
            try
            {
                dao.InitialiserConnexion();
                dao.conn.Open();
                dao.cmd = new SqlCommand(requete, dao.conn);
                dao.dp = new SqlDataAdapter(dao.cmd);
                dao.dst = new DataSet();
                dao.dp.Fill(dao.dst, requete);
                dao.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dao.dst;
        }
        public string Admin__(string admi)
        {
            string Nom = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select NomUtilisateur from Utilisateur where NomUtilisateur = '" + admi + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nom = (dr["NomUtilisateur"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return Nom;
        }
    }
}