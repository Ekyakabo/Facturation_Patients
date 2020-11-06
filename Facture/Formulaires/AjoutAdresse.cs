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
    public partial class AjoutAdresse : Form
    {
        public AjoutAdresse()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjoutAdresse_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);

        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        Adresse adr = new Adresse();
        string id="0";
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Adresse where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void ActionBtn()
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            adr.Id = id;
                            adr.Pays = fx.ValidateName(pays.Text);
                            adr.Province = fx.ValidateName(Province.Text);
                            adr.Ville = fx.ValidateName(ville.Text);
                            adr.Commune = fx.ValidateName(commune.Text);
                            adr.Quartier = fx.ValidateName(quartier.Text);
                            adr.Avenue = fx.ValidateName(avenue.Text);
                            adr.Numero = numero.Text;
                            if(adr.Enregistrer()==true)
                            {
                                fx.Message(1);
                            Actualiser();
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            adr.Id = id;
                            adr.Pays = fx.ValidateName(pays.Text);
                            adr.Province = fx.ValidateName(Province.Text);
                            adr.Ville = fx.ValidateName(ville.Text);
                            adr.Commune = fx.ValidateName(commune.Text);
                            adr.Quartier = fx.ValidateName(quartier.Text);
                            adr.Avenue = fx.ValidateName(avenue.Text);
                            adr.Numero = numero.Text;
                            if (adr.Enregistrer() == true)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            ActionBtn();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
        public void Actualiser()
        {
            pays.Text = "";
            Province.Text = "";
            commune.Text = "";
            ville.Text = "";
            quartier.Text = "";
            avenue.Text = "";
            numero.Text = "";
            save.Visible = true;
            update.Visible = false;
            DataGrid();
            btnSave.Text = "Enregistrer";
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                update.Visible = true;
                save.Visible = false;
                id = Table.SelectedCells[0].Value.ToString();
                pays.Text = Table.SelectedCells[1].Value.ToString();
                Province.Text = Table.SelectedCells[2].Value.ToString();
                ville.Text = Table.SelectedCells[3].Value.ToString();
                commune.Text = Table.SelectedCells[4].Value.ToString();
                quartier.Text = Table.SelectedCells[5].Value.ToString();
                avenue.Text = Table.SelectedCells[6].Value.ToString();
                numero.Text = Table.SelectedCells[7].Value.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text == "Tapez ici le mot de Recherche")
            {
                rech.Text = "";
            }
        }

        private void rech_MouseLeave(object sender, EventArgs e)
        {
            if (rech.Text == "")
            {
                rech.Text = "Tapez ici le mot de Recherche"; Table.Focus();
                DataGrid();
            }
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from Adresse  where id is not null and  numero LIKE '%" + rech.Text + "%' or Avenue LIKE '%" + rech.Text + "%' or Quartier LIKE '%" + quartier.Text + "%'");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void quartier_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void avenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void commune_TextChanged(object sender, EventArgs e)
        {

        }

        private void Province_TextChanged(object sender, EventArgs e)
        {

        }

        private void pays_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
