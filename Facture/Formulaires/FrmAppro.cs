using DevExpress.XtraReports.UI;
using Facture.ClsProprietes;
using Facture.ClsTraitements;
using Facture.Connexion;
using Facture.Fonctions;
using Facture.Proprietes;
using Facture.Rapports;
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
    public partial class FrmAppro : Form
    {
        public FrmAppro()
        {
            InitializeComponent();
        }

        private void AjoutPersonne_Click(object sender, EventArgs e)
        {
            Medicament m = new Medicament();
            m.ShowDialog();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        string id = "0";
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Appro_Medicament");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void FrmAppro_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            pro.ChargerCombo("Liste_Medicament where id is not null", designation, "Produit");
            pro.Autocomplete("select Produit  from Liste_Medicament where id is not null ", "Produit", designation); 
        }
        public void Actualiser()
        {
            designation.Text = "";
            txtQte.Text = "00";
            txtPrix.Text = "00";
            DataGrid(); panel6.Visible = false;
            save.Visible = true;
            update.Visible = true;
            btnSave.Text = "Enregistrer";
            pro.ChargerCombo("Liste_Medicament where id is not null", designation, "Produit");
            tableAdd.Rows.Clear();
        }
        Approvision app = new Approvision();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            app.Id = fx.ValidateName(id);
                            app.IdAgent = fx.ValidateName(idagent.Text);
                            if (app.Entete()==true)
                            {
                                if (app.Enregistrer(tableAdd) == true)
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
                            app.Id = fx.ValidateName(id);
                            app.IdAgent = fx.ValidateName(idagent.Text);
                            if (app.Entete() == true)
                            {
                                if (app.Enregistrer(tableAdd) == true)
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
        private void designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            app.IdMedicament = pro.IdCombo("Liste_Medicament", designation.Text, "Produit");
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
                        if (fx.occurrence(tableAdd, app.IdMedicament) == 0)
                        {                            
                            fx.ajouterDatagrid2(tableAdd, app.IdMedicament, designation.Text, txtfab.Value.ToString(), txtExp.Value.ToString(),int.Parse(txtQte.Text), Decimal.Parse(txtPrix.Text));
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
                MessageBox.Show("Ok");
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
                Table.DataSource = d.recherche_UsignSql("select * from Appro_Medicament  where id is not null and  Medicament LIKE '%" + rech.Text + "%'");

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

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
        int qtes = 0;
        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
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
                        tableAdd.SelectedRows[0].Cells[4].Value = qtes;
                        panel6.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tableAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtQte_TextChanged(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, txtQte);
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, txtPrix);
        }
        ClsRapports clr = new ClsRapports();
        private void label15_Click(object sender, EventArgs e)
        {
            RpAppro xtp = new RpAppro();
            xtp.DataSource = clr.GetInstance().SelectAll("Appro_Medicament");
            ReportPrintTool printTool = new ReportPrintTool(xtp);
            printTool.ShowRibbonPreview();

        }

        private void resultat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
