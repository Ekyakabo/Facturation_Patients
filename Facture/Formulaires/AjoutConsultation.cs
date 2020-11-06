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
    public partial class AjoutConsultation : Form
    {
        public AjoutConsultation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Actualiser()
        {
            symptome.Text = "";
            patient.Text = "";
            tarif.Text = "";
            montant.Text = "00";
            save.Visible = true;
            update.Visible = false;
            btnSave.Text = "Enregistrer";
            DataGrid();

        }
        Consultation c = new Consultation();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSave.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            c.Id = id;
                            c.Symptome = fx.ValidateName(symptome.Text);
                            c.IdPatient = pro.IdCombo("liste_Patient", patient.Text, "Noms");
                            c.IdAgent = fx.ValidateName(idagent.Text);
                            if (c.Enregistrer() == true)
                            {
                                fx.Message(1);
                                Actualiser();
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            c.Id = id;
                            c.IdPatient = pro.IdCombo("liste_Patient", patient.Text, "Noms");
                            c.Idtarif = pro.IdCombo("Tarif", tarif.Text, "Designation");
                            c.Symptome = fx.ValidateName(symptome.Text);
                            c.IdAgent = fx.ValidateName(idagent.Text);
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_RichTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprovenance_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from Liste_consultation  where id is not null and  Patient LIKE '%" + rech.Text + "%' or Symptome LIKE '%" + rech.Text + "%'");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
         //Consultation adr = new Consultation();
        string id="0";
        private void AjoutConsultation_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            pro.ChargerCombo("Liste_Patient where id is not null", patient, "Noms");
            pro.Autocomplete("select Noms  from Liste_Patient", "Noms", patient);
            pro.ChargerCombo("Tarif where id is not null and designation like '%Consultation%' ", tarif, "Designation");
            fx.Picture_Rond(profil);
        }
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("liste_consultation where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.IdPatient = pro.IdCombo("liste_Patient", patient.Text, "Noms");
            d.RetournerPhotoSQl("Profil", "Liste_Patient", "Id", c.IdPatient, profil);

        }

        private void tarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.Idtarif = pro.IdCombo("Tarif", tarif.Text, "Designation");
            montant.Text = pro.RetournerValueur("select Montant  as Valeur from Tarif where designation ='" + tarif.Text + "'");

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
                tarif.Text= Table.SelectedCells[5].Value.ToString();
                montant.Text = Table.SelectedCells[6].Value.ToString();
                d.RetournerPhotoSQl("Profil", "Liste_Patient", "Noms", patient.Text, profil);
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
        ClsRapports clr = new ClsRapports();

        private void label15_Click(object sender, EventArgs e)
        {
            RpConsultation xtp = new RpConsultation();
            xtp.DataSource = clr.GetInstance().SelectAll("liste_consultation where id is not null");
            ReportPrintTool printTool = new ReportPrintTool(xtp);
            printTool.ShowRibbonPreview();
        }
    }
}
