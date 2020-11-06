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
    public partial class Medicament : Form
    {
        public Medicament()
        {
            InitializeComponent();
        }

        private void Medicament_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            DataGrid();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        string id = "0";
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Medicament where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                save.Visible = true;
                update.Visible = false;
                id = Table.SelectedCells[0].Value.ToString();
                produit.Text = Table.SelectedCells[1].Value.ToString();
                Dosage.Text = Table.SelectedCells[2].Value.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void Actualiser()
        {
            produit.Text = "";
            Dosage.Text="";
            update.Visible = false;
            save.Visible = true;
            btnSave.Text = "Enregistrer";
            DataGrid();
        }
        ClsMedicament m = new ClsMedicament();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            m.Id = id;
                            m.Designation = fx.ValidateName(produit.Text);
                            m.Dosage = fx.ValidateName(Dosage.Text);
                            if (m.Enregistrer() == true)
                            {
                                fx.Message(1);
                                Actualiser();
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            m.Id = id;
                            m.Designation = fx.ValidateName(produit.Text);
                            m.Dosage = fx.ValidateName(Dosage.Text);
                            if (m.Enregistrer() == true)
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
           
            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Conn.Close();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from Medicament  where id is not null and  designation LIKE '%" + rech.Text + "%' or dosage LIKE '%" + rech.Text + "%'");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void rech_MouseLeave(object sender, EventArgs e)
        {
            if (rech.Text == "")
            {
                rech.Text = "Tapez ici le mot de Recherche"; Table.Focus();
                DataGrid();
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {

            if (rech.Text == "Tapez ici le mot de Recherche")
            {
                rech.Text = "";
            }
        }
    }
}
