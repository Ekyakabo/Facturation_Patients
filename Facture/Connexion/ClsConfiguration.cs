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

namespace ManagerConnection
{
    public class ClsConfiguration
    {

        public static bool CreationDeFichierConf(Connexions con ,ConnexionType connexionType)
        {
            bool reponse = false;
            string chemin = "";            
            switch (connexionType)
            {
                case ConnexionType.SQLServer:
                    chemin = "Data Source=" + con.Serveur + "; Initial Catalog=" + con.Database + "; User Id=" + con.User + "; Password=" + con.Password+";";
                    File.WriteAllText(ClsConstante.Table.cheminSql, chemin.ToString());                   
                    reponse= true;
                    break;
                case ConnexionType.MySQL:
                    chemin = "Server=" + con.Serveur + "; Database=" + con.Database + "; UserId=" + con.User + "; Password=" + con.Password + ";";
                   // File.WriteAllText(ClsConstante.Table.cheminMysql, chemin.ToString());
                    reponse = true;
                    break;
            }
            return reponse;
        }
        Connexions con = new Connexions();

        public bool backUp1(string txtpar, string database)
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                if (txtpar == string.Empty)
                {
                    MessageBox.Show("Veiller parcouris svp Avant de faire le backup");
                }
                else
                {             

                    using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                    {
                        //cmd.CommandText = "BACKUP DATABASE [" + database + "] TO DISK='" + txtpar + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")+".bak'";
                        cmd.CommandText = "USE MASTER BACKUP DATABASE [" + database + "] TO DISK= N'" + txtpar + "\\" + database +".bak' WITH FILE = 1;";
                        //  cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Backup reçu! ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        txtpar = "";
                        reponse = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }
        public void restaure_backup(string textrestor, string database)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                //using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                //{
                //    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                //    cmd.CommandText = sqlStmt2;
                //    cmd.ExecuteNonQuery();
                //}
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {

                   cmd.CommandText = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK= N'" + textrestor + "' WITH REPLACE;";                 
                   cmd.ExecuteNonQuery();
                }
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText =  string.Format("USE MASTER ALTER DATABASE [" + database + "] SET MULTI_USER");
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("La base de données est restaurée avec succès!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                textrestor = "";
                ImplementeConnexion.Instance.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string  nomchemin;
        public string CheminFichier(int choix)
        {
            try
            {
                switch (choix)
                {
                    case 1:
                        FolderBrowserDialog fi = new FolderBrowserDialog();
                        if (fi.ShowDialog() == DialogResult.OK)
                        {
                            nomchemin = fi.SelectedPath;
                        }
                        else { nomchemin = ""; }

                        break;
                    case 2:
                        OpenFileDialog rest = new OpenFileDialog();
                        rest.Filter = "SQL SERVER database backup files|*.bak";
                        rest.Title = "Restauration de base de données";
                        rest.ShowDialog();
                        if (rest.ShowDialog() == DialogResult.OK)
                        {
                            nomchemin = rest.FileName;
                        }
                        else { nomchemin = ""; }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nomchemin;

        }
    }
}
