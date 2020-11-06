using Facture.ClsProprietes;
using Facture.ClsTraitements;
using Facture.Connexion;
using Facture.Fonctions;
using Facture.Proprietes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.Formulaires
{
    public partial class AjoutTarif : Form
    {
        public AjoutTarif()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        Tarif t = new Tarif();
        string id = "0";
        private void AjoutTarif_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
        }
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Tarif");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public void Actualiser()
        {
            designation.Text = "";
            montant.Text = "";
            save.Visible = true;
            update.Visible = false;
            montant.Text = "00";
            DataGrid();
        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                save.Visible = true;
                update.Visible = false;
                id = Table.SelectedCells[0].Value.ToString();
                designation.Text = Table.SelectedCells[1].Value.ToString();
                montant.Text = Table.SelectedCells[2].Value.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            t.Id = id;
                            t.Designation = fx.ValidateName(designation.Text);
                            t.Montant = decimal.Parse(montant.Text);
                            if (t.Enregistrer() == true)
                            {
                                fx.Message(1);
                                Actualiser();
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            t.Id = id;
                            t.Designation = fx.ValidateName(designation.Text);
                            t.Montant = decimal.Parse(montant.Text);
                            if (t.Enregistrer() == true)
                            {
                                fx.Message(2);
                                Actualiser();
                            }

                        }
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Conn.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from tarif  where id is not null and  designation LIKE '%" + recherche.Text +  "%'");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void recherche_Enter(object sender, EventArgs e)
        {

            if (recherche.Text == "Tapez ici le mot de Recherche")
            {
                recherche.Text = "";
            }
        }
        private void recherche_MouseLeave(object sender, EventArgs e)
        {
            if (recherche.Text == "")
            {
                recherche.Text = "Tapez ici le mot de Recherche"; Table.Focus();
                DataGrid();
            }
        }

        private void montant_TextChanged(object sender, EventArgs e)
        {
                }

        private void montant_TextChanged_1(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, montant);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
