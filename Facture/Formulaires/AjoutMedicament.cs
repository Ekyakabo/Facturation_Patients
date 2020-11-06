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
    public partial class AjoutMedicament : Form
    {
        public AjoutMedicament()
        {
            InitializeComponent();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        string id = "0";
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Liste_Consommation where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void resultat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjoutMedicament_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            ClsFonctions.Instance.ProprieteDatagrid(tableAdd);
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            pro.ChargerCombo("Liste_Patient where id is not null", patient, "Noms");
            pro.ChargerCombo("Appro_Medicament where id is not null", designation, "distinct Medicament");
            pro.Autocomplete("select Noms  from Liste_Patient", "Noms", patient);
            pro.Autocomplete("select distinct Medicament  from Appro_Medicament", "Medicament", patient);
            fx.Picture_Rond(profil); DataGrid();
            save.Visible = true;
            panel6.Visible = false;
            update.Visible = false;
        }
        Consommation c = new Consommation();  
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            c.Id = fx.ValidateName(id);
                            c.IdPatient = pro.IdCombo("Liste_Patient", patient.Text, "Noms");
                            c.IdAgent = fx.ValidateName(idagent.Text);
                            if (c.Entete() == true)
                            {
                                if (c.Enregistrer(tableAdd) == true)
                                {
                                    fx.Message(1);
                                    Actualiser();
                                }
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            c.Id = fx.ValidateName(id);
                            c.IdAgent = fx.ValidateName(idagent.Text);
                            if (c.Entete() == true)
                            {
                                if (c.Enregistrer(tableAdd) == true)
                                {
                                    fx.Message(2);
                                    Actualiser();
                                }
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
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQte.Text.Equals("") || txtPrix.Text.Equals(""))
                {

                }
                else
                {
                    int qte;
                    qte = int.Parse(txtQte.Text);
                    if (qte <= 0)
                    {
                        MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (fx.occurrence(tableAdd, c.IdMedicament) == 0)
                        {
                            fx.ajouterDatagrid(tableAdd, c.IdMedicament, designation.Text, decimal.Parse(txtPrix.Text),int.Parse(txtQte.Text));
                            designation.Text = "";
                            txtPrix.Text = "00";
                            txtQte.Text = "00";
                        }
                        else
                        {
                            MessageBox.Show("Cet produit existe déjà ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //id = tableAdd.SelectedRows[0].Cells[0].Value.ToString();
                qt.Text = tableAdd.SelectedRows[0].Cells[4].Value.ToString();
                panel6.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show("Charger d'abord le panier ", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtQte_TextChanged(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, txtQte);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
        public void Actualiser()
        {
            designation.Text = "";
            patient.Text = "";
            txtPrix.Text = "";
            DataGrid();
            save.Visible = true;
            update.Visible = true;
            panel6.Visible = false;
            txtQte.Text = "00";
            txtPrix.Text = "00";
            btnSave.Text = "Enregistrer";
        }
        private void rech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from Liste_Consommation  where id is not null and  produit LIKE '%" + rech.Text + "%' or patient like '%"+rech.Text+"%'");

            }
            catch (Exception ex)     
            { MessageBox.Show(ex.Message); }
        }
        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.IdPatient = pro.IdCombo("Liste_Patient", patient.Text, "Noms");
        }
        private void designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.IdMedicament = pro.IdCombo("Appro_Medicament", designation.Text, "Medicament");
            txtPrix.Text = pro.RetournerValueur("select PrixUnit  as Valeur from Appro_Medicament where Medicament ='" + designation.Text + "'");
        }
        int qtes = 0;
        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            try
            {
                if (qt.Text.Equals(""))
                {
                    MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    qtes = int.Parse(qt.Text);

                    if (qtes <= 0)
                    {
                        MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tableAdd.SelectedRows[0].Cells[3].Value = qtes;
                        panel6.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                save.Visible = false;
                update.Visible = true;
                id = Table.SelectedCells[0].Value.ToString();
                patient.Text = Table.SelectedCells[3].Value.ToString();
                designation.Text = Table.SelectedCells[4].Value.ToString();
                txtQte.Text = Table.SelectedCells[5].Value.ToString();
                d.RetournerPhotoSQl("Profil", "Liste_Patient", "Noms", patient.Text, profil);
                txtPrix.Text = pro.RetournerValueur("select PrixUnit  as Valeur from Appro_Medicament where Medicament ='" + designation.Text + "'");

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
    }
}
