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
    public partial class AjoutPersonne : Form
    {
        public AjoutPersonne()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void AjoutPersonne_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            pro.ChargerCombo("Liste_Adresse", adresse, "Designation");
            fx.Picture_Rond(profil);
            pro.Autocomplete("select Avenue  from Adresse", "Avenue", adresse);
            ClsFonctions.Instance.ProprieteDatagrid(Table);
        }
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Liste_Personne where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
          Personne p = new Personne();
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
                            p.Id = id;
                            p.Nom = fx.ValidateName(txtnom.Text);
                            p.Postnom = fx.ValidateName(txtpostnom.Text);
                            p.Prenom = fx.ValidateName(txtPrenom.Text);
                            p.Sex = fx.ValidateName(txtsexe.Text);
                            p.LieuNaiss = fx.ValidateName(iTalk_RichTextBox1.Text);
                            p.DateNaiss = dateTimePicker3.Text;
                            p.Phone = Phone.Text;
                            p.Profil = fx.RetournerBytePhoto(profil.Image);
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
                            p.Nom = fx.ValidateName(txtnom.Text);
                            p.Postnom = fx.ValidateName(txtpostnom.Text);
                            p.Prenom = fx.ValidateName(txtPrenom.Text);
                            p.Sex = fx.ValidateName(txtsexe.Text);
                            p.LieuNaiss = fx.ValidateName(iTalk_RichTextBox1.Text);
                            p.DateNaiss = dateTimePicker3.Text;
                            p.Phone = Phone.Text;
                            p.Profil = fx.RetournerBytePhoto(profil.Image);
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fx.ImporterPhoto(profil);
        }
        public void Actualiser()
        {
            save.Visible = true;
            update.Visible = false;
            txtnom.Text = "";
            txtpostnom.Text = "";
            txtPrenom.Text = "";
            txtsexe.Text = "";
            Phone.Text = "";
            adresse.Text = "";
            DataGrid();
            btnSave.Text = "Enregistrer";
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Actualiser();
        }

        private void adresse_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Adresse = pro.IdCombo("Liste_Adresse", adresse.Text, "Designation");
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
                Table.DataSource = d.recherche_UsignSql("select * from Liste_Personne  where id is not null and  Nom LIKE '%" + recherche.Text + "%' or Postnom LIKE '%" + recherche.Text + "%' or prenom LIKE '%" + recherche.Text + "%'");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                save.Visible = false;
                update.Visible = true;
                id = Table.SelectedCells[0].Value.ToString();
                txtnom.Text = Table.SelectedCells[1].Value.ToString();
                txtpostnom.Text = Table.SelectedCells[2].Value.ToString();
                txtPrenom.Text = Table.SelectedCells[3].Value.ToString();
                txtsexe.Text = Table.SelectedCells[4].Value.ToString();
                iTalk_RichTextBox1.Text = Table.SelectedCells[5].Value.ToString();
                dateTimePicker3.Text = Table.SelectedCells[6].Value.ToString();
                Phone.Text = Table.SelectedCells[7].Value.ToString();
                adresse.Text= Table.SelectedCells[8].Value.ToString();
                d.RetournerPhotoSQl("Profil", "Personne", "Id", id, profil);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AjoutAdresse ad = new AjoutAdresse();
            ad.ShowDialog();
        }
    }
}
