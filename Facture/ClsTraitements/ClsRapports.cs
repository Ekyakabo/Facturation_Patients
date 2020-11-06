using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.ClsTraitements
{
    public class ClsRapports
    {
        ClsDAO gl = new ClsDAO();
        private static ClsRapports rapport;
        //  Rapport_Contribution_mansuelle rap = new Rapport_Contribution_mansuelle();

        public ClsRapports GetInstance()
        {
            if (rapport == null)
                rapport = new ClsRapports();
            return rapport;
        }

        public DataSet liste(string requete)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand(requete, gl.conn);
                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, requete);
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;

        }
        public DataSet listes(string table, string colone)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand(" select * from " + table + " where Id ='" + colone + "'", gl.conn);
                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, table);
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;

        }
        public DataSet liste(string table, string colonne1, string dp)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + dp + "'", gl.conn);

                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, table);
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;

        }
        public DataSet Selection_Date(string date1, string date2)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand("select * from V_CULTE where DATE_CULTE between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, "V_CULTE");
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;
        }
        public DataSet Selection_Date_oper(string date1, string date2)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand("select * from V_Operation___ where ADDDATE between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, "V_Operation___");
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;
        }
        public DataSet SelectAll(string table)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand("select * from "+ table + "", gl.conn);
                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, table);
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;
        }
        public DataSet journal(string date1, string date2)
        {
            gl.InitialiserConnexion();

            try
            {
                gl.conn.Open();
                gl.cmd = new SqlCommand("select * from Journal_Filtre where ADDDATE between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
                gl.dp = new SqlDataAdapter(gl.cmd);
                gl.dst = new DataSet();
                gl.dp.Fill(gl.dst, "Journal_Filtre");
                gl.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gl.dst;
        }

    }
}
