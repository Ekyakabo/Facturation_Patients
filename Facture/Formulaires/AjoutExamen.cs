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
    public partial class AjoutExamen : Form
    {
        public AjoutExamen()
        {
            InitializeComponent();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void AjoutExamen_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            pro.ChargerCombo("liste_consultation where id is not null", patient, "Patient");
            pro.ChargerCombo("Tarif where id is not null and designation like '%Examen%'", tarif, "Designation");
            pro.Autocomplete("select Patient  from liste_consultation where id is not null ", "Patient", patient);
            fx.Picture_Rond(profil);
        }
        public void DataGrid()
        {
            try
            {
                  Table.DataSource = d.GetTableUsingSql("liste_Examen where id is not null");                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        Examen ex = new Examen();
        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {           
            ex.IdPatient = pro.IdCombo("Liste_patient", patient.Text, "Noms");
            symptome.Text=pro.RetournerValueur("select Symptome  as Valeur from liste_consultation where Patient ='" + patient.Text+"'");
            d.RetournerPhotoSQl("Profil", "Liste_Patient", "Noms", patient.Text, profil);
            ex.IdConsultation = pro.IdCombo__("select Id from liste_consultation where  id is not null and symptome ='" + symptome.Text + "' and patient='" + patient.Text + "'");
            d.RetournerPhotoSQl("Profil", "Liste_patient", "Id", ex.IdPatient, profil);
        }
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
                            ex.Id = fx.ValidateName(id);
                            ex.Resultat = fx.ValidateName(symptome.Text);
                            ex.IdAgent = fx.ValidateName(idagent.Text);
                            ex.IdPatient = pro.IdCombo("Liste_patient", patient.Text, "Noms");
                            ex.Idtarif =fx.ValidateName( pro.IdCombo("Tarif", tarif.Text, "Designation"));
                            ex.IdConsultation =fx.ValidateName(pro.IdCombo__("select Id from liste_consultation where  id is not null and symptome ='" + symptome.Text + "' and patient='" + patient.Text + "'"));
                            if (ex.Enregistrer() == true)
                            {
                                fx.Message(1);
                                Actualiser();
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            ex.Id = fx.ValidateName(id);
                            ex.Resultat = fx.ValidateName(symptome.Text);
                            ex.IdAgent = fx.ValidateName(idagent.Text);
                            ex.IdPatient = pro.IdCombo("Liste_patient", patient.Text, "Noms");
                            ex.Idtarif = fx.ValidateName(pro.IdCombo("Tarif", tarif.Text, "Designation"));
                            ex.IdConsultation = fx.ValidateName(pro.IdCombo__("select Id from liste_consultation where  id is not null and symptome ='" + symptome.Text + "' and patient='" + patient.Text + "'"));
                            if (ex.Enregistrer() == true)
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
        public void Actualiser()
        {
            patient.Text = "";
            symptome.Text="";
            result.Text = "";
            tarif.Text = "";
            montant.Text = "00";
            save.Visible = true;
            update.Visible = false;
            btnSave.Text = "Enregistrer";
            DataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void tarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            ex.Idtarif = pro.IdCombo("Tarif", tarif.Text, "Designation");
            montant.Text = pro.RetournerValueur("select Montant  as Valeur from Tarif where designation ='" + tarif.Text + "'");

        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from Liste_Examen  where id is not null and  Patient LIKE '%" + rech.Text + "%' or resultat='"+ result.Text+"' or Symptome LIKE '%" + rech.Text + "%'");

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

        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                save.Visible = false;
                update.Visible = true;
                id = Table.SelectedCells[0].Value.ToString();
                patient.Text = Table.SelectedCells[3].Value.ToString();
                symptome.Text = Table.SelectedCells[4].Value.ToString();
                result.Text = Table.SelectedCells[5].Value.ToString();
                tarif.Text = Table.SelectedCells[6].Value.ToString();
                montant.Text = Table.SelectedCells[7].Value.ToString();
                d.RetournerPhotoSQl("Profil", "Liste_Patient", "Noms", patient.Text, profil);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        ClsRapports clr = new ClsRapports();

        private void label15_Click(object sender, EventArgs e)
        {
            Rp_Resultat xtp = new Rp_Resultat();
            xtp.DataSource = clr.GetInstance().SelectAll("Liste_Examen  where id is not null");
            ReportPrintTool printTool = new ReportPrintTool(xtp);
            printTool.ShowRibbonPreview();
        }
    }
}
