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
    public partial class AjoutCategorie : Form
    {
        public AjoutCategorie()
        {
            InitializeComponent();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjoutCategorie_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(profil);
        }
        public void DataGrid()
        {
            try
            {
                if(radioButton1.Checked==true)
                {
                    Table.DataSource = d.GetTableUsingSql("Liste_Agent where id is not null");
                }
                if (radioButton2.Checked == true)
                {
                    Table.DataSource = d.GetTableUsingSql("Liste_Patient where id is not null");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectionner();
        }
        public void selectionner()
        {
            ImplementeConnexion.Instance.Initialise();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            if (radioButton1.Checked==true)
            {
                groupBox1.Enabled = true;
                groupBox3.Enabled = false;
                personne1.Items.Clear();
                DataGrid();
                pro.ChargerCombo("ComboPersonne", personne1, "Noms");
                fx.Picture_Rond(profil);
                pro.Autocomplete("select Noms  from ComboPersonne", "Noms", personne1);
            }
            else 
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
                groupBox3.Enabled = true;
                personne2.Items.Clear();
                DataGrid();
                pro.ChargerCombo("ComboPersonne", personne2, "Noms");
                fx.Picture_Rond(profil);
                pro.Autocomplete("select Noms  from ComboPersonne", "Noms", personne2);
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectionner();
        }
        Agent a = new Agent();
        Patient p = new Patient();
        private void personne1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                a.IdPersonne = pro.IdCombo("ComboPersonne", personne1.Text, "Noms");
                d.RetournerPhotoSQl("Profil", "ComboPersonne", "Noms", personne1.Text, profil);

            }
        }

        private void personne2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                p.IdPersonne = pro.IdCombo("ComboPersonne", personne2.Text, "Noms");
                d.RetourPhoto("SQLServer", p.IdPersonne, profil);
                d.RetournerPhotoSQl("Profil", "ComboPersonne", "Noms", personne2.Text, profil);
            }
        }
           string id = "0";
        public void Actualiser()
        {
            personne1.Text = "";
            personne2.Text = "";
            fonction.Text = "";
            DataGrid();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                try
                {
                    switch (btnSave.Text)
                    {
                        case "Enregistrer":
                            if (fx.Question(1) == true)
                            {
                                a.Id = id;
                                a.Fonction = fx.ValidateName(fonction.Text);
                                if (a.Enregistrer() == true)
                                {
                                    fx.Message(1);
                                    Actualiser();
                                }
                            }
                            break;
                        case "Modifier":
                            if (fx.Question(2) == true)
                            {
                                a.Id = id;
                                a.Fonction = fx.ValidateName(fonction.Text);
                                
                                if (a.Enregistrer() == true)
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
            else if(radioButton2.Checked==true)
            {
                try
                {
                    switch (btnSave.Text)
                    {
                        case "Enregistrer":
                            if (fx.Question(1) == true)
                            {
                                p.Id = id;
                                p.IdAgent = idagent.Text;                        
                                if (p.Enregistrer() == true)
                                {
                                    fx.Message(1);
                                    Actualiser();
                                }
                            }
                            break;
                        case "Modifier":
                            if (fx.Question(2) == true)
                            {
                                p.Id = id;
                                p.IdAgent = idagent.Text;
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
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    btnSave.Text = "Modifier";
                    id = Table.SelectedCells[0].Value.ToString();
                    personne1.Text = Table.SelectedCells[1].Value.ToString();
                    fonction.Text = Table.SelectedCells[2].Value.ToString();
                    a.IdPersonne = pro.IdCombo("ComboPersonne", personne1.Text, "Noms");
                    d.RetourPhoto("SQLServer", a.IdPersonne, profil);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else if(radioButton2.Checked==true)                    
              {
                try
                {
                    btnSave.Text = "Modifier";
                    id = Table.SelectedCells[0].Value.ToString();
                    personne2.Text = Table.SelectedCells[1].Value.ToString();

                    p.IdPersonne = pro.IdCombo("ComboPersonne", personne2.Text, "Noms");

                    d.RetourPhoto("SQLServer", id, profil);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
        private void initialiser_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        ClsRapports clr = new ClsRapports();
        private void label15_Click(object sender, EventArgs e)
        {
            Fiche_Patient xtp = new Fiche_Patient();
            xtp.DataSource = clr.GetInstance().listes("Fiche_Patient",p.Id);
            ReportPrintTool printTool = new ReportPrintTool(xtp);
            printTool.ShowRibbonPreview();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


