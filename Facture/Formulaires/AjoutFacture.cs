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
    public partial class AjoutFacture : Form
    {
        public AjoutFacture()
        {
            InitializeComponent();
        }

        private void montant_TextChanged(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, montant);
        }

        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void AjoutFacture_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid(); fx.Picture_Rond(profil);
            pro.ChargerCombo("Liste_Patient where id is not null", patient, "Noms");
            pro.Autocomplete("select Noms  from Liste_Patient where id is not null ", "Noms", patient);
            ClsFonctions.Instance.ProprieteDatagrid(Table);
        }
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Liste_Paiement where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
        public void Actualiser()
        {
            patient.Text = "";
            montant.Text = "00";
            apayer.Text = "00";
            DataGrid();
            save.Visible = true;
            update.Visible = false;
            btnSave.Text = "Enregistrer";
        }
        Paiement p = new Paiement();
        string id = "0";
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            p.Id = fx.ValidateName(id);
                            p.IdAgent = fx.ValidateName(idagent.Text);
                            p.IdPatient = pro.IdCombo("Liste_patient", patient.Text, "Noms");
                            p.Montant = decimal.Parse(fx.ValidateName(montant.Text));

                            if (apayer.Text.Equals(montant.Text))
                            {
                                if (p.Enregistrer() == true)
                                {
                                    fx.Message(1);
                                    Actualiser();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Désolé vous devez entrer la totalité de frais à payer !, " , "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            p.Id = fx.ValidateName(id);
                            p.IdAgent = fx.ValidateName(idagent.Text);
                            p.IdPatient = pro.IdCombo("Liste_patient", patient.Text, "Noms");
                            p.Montant = decimal.Parse(fx.ValidateName(montant.Text));
                            if (p.Enregistrer() == true)
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.IdPatient = pro.IdCombo("Liste_Patient", patient.Text, "Noms");
            apayer.Text = pro.RetournerValueur("select Apayer  as Valeur from Liste_Paiement where etat=0 and Patient ='" + patient.Text + "'");
            d.RetournerPhotoSQl("Profil", "Liste_patient", "Id", p.IdPatient, profil);
            montant.Text = "00";

        }

        ClsRapports clr = new ClsRapports();
        private void label15_Click(object sender, EventArgs e)
        {
            if (!p.Id.Equals(""))
            {
                RpFact xtp = new RpFact();
                xtp.DataSource = clr.GetInstance().listes("Liste_Paiement", p.Id);
                ReportPrintTool printTool = new ReportPrintTool(xtp);
                printTool.ShowRibbonPreview();
            }
            else
            {
                MessageBox.Show("Désolé veuillez selectionner un nom de la table!, " , "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                update.Visible = true;
                save.Visible = false;
                p.Id = Table.SelectedCells[0].Value.ToString();
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

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from Liste_Paiement where id is not null and  patient LIKE '%" + recherche.Text + "%''");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
