using Facture.ClsTraitements;
using Facture.Connexion;
using Facture.Fonctions;
using Facture.Proprietes;
using GestionPersonneLib.Proprietes;
using ManagerConnection;
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
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();
        }
        public void initialiser()
        {
            txtserveur.Text = ""; txtdatabase.Text = ""; txtusername.Text = ""; txtpassword.Text = "";
        }
        Connexions con = new Connexions();
        ClsFonctions fx = new ClsFonctions();
        String chem;
        private ConnexionType connexionType;

          private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtserveur.Text.Equals("") || txtdatabase.Text.Equals("") || txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                MessageBox.Show("Veuillez completer le(s) champs", "Création de fichier config", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    Connexions.TestFile();
                    con.Database = txtdatabase.Text;
                    con.Serveur = txtserveur.Text;
                    con.User = txtusername.Text;
                    con.Password = txtpassword.Text;
                    if (ClsConfiguration.CreationDeFichierConf(con, connexionType) == true)
                    {
                        MessageBox.Show("Configuration reçu!", "Création de fichier config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiser();
                        ImplementeConnexion.Instance.Initialise();
                    }
                    else
                    {
                        MessageBox.Show("Configuration echouée!", "Création de fichier config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        ProprietePublique pro = new ProprietePublique();
        DynamicClass d = new DynamicClass();
        Administrateur a = new Administrateur();
        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            ok.Visible = false;
            pictureBox7.Visible = false;
            fx.Picture_Rond(profil);
            txtserveur.Items.Add(".");
            txtserveur.Items.Add("localhost");
            txtserveur.Items.Add(@".\SQLEXPRESS");
            txtserveur.Items.Add(string.Format(@"{0}", Environment.MachineName) + "" + "\\SA");
            txtserveur.Items.Add(string.Format(@"{0}", Environment.MachineName));

            if (Connexions.TestFile() == true)
            {
                ImplementeConnexion.Instance.Initialise();
                ClsFonctions.Instance.ProprieteDatagrid(Table);
                DataGrid();
                if(choix.Text.Equals("1"))
                {
                    Agent.Visible = false;
                    panel1.Visible = false;
                    label9.Visible = false;
                }
                else if (choix.Text.Equals("2"))

                {
                    pro.ChargerCombo("Liste_Agent", Agent, "Noms");
                    Agent.Visible = true;
                    panel1.Visible = true;
                    label9.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Désolé les fichier de la connexion est introuvable ! , ", "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("Liste_User where id is not null");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void label6_Click(object sender, EventArgs e)
        {
            FrmServeur ser = new FrmServeur();
            ser.ShowDialog();
        }

        private void confirmer_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals(confirmer.Text))
            {
                ok.Visible = true;
                btnSave.Enabled = true;
                confirmer.ForeColor = Color.Black;
            }
            else
            {
                ok.Visible = false;
                confirmer.ForeColor = Color.Red;
                btnSave.Enabled = false;
            }
        }
        private void conf_TextChanged(object sender, EventArgs e)
        {
            if (pwd.Text.Equals(conf.Text))
            {
                pictureBox7.Visible = true;
                autres.Enabled = true;
            }
            else
            {
                pictureBox7.Visible = false;
                autres.Enabled = false;
            }
        }
        string id = "0";
        public void Actualiser()
        {
            Agent.Text = "";
            conf.Text = "";
            username.Text = "";
            pwd.Text = "";
            niveau.Text = "";
            autres.Text = "Enregistrer";
            DataGrid();
        }
        private void autres_Click(object sender, EventArgs e)
        {
            try
            {
                switch (autres.Text)
                {
                    case "Enregistrer":
                        if (fx.Question(1) == true)
                        {
                            a.Id = id;
                            a.Username = fx.ValidateName(username.Text);
                            a.Niveau = int.Parse(niveau.Text);                           
                            a.Pwd = fx.ValidateName(conf.Text);
                            a.Profil = fx.RetournerBytePhoto(profil.Image);
                            if (choix.Text.Equals("1"))
                            {
                                if (a.Enregistrer1() == true)
                                {
                                    fx.Message(1);
                                    Actualiser();
                                }
                            }
                            else if (choix.Text.Equals("2"))
                            {
                                if (a.Enregistrer2() == true)
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
                            a.Id = id;
                            a.Username = fx.ValidateName(username.Text);
                            a.Niveau = int.Parse(niveau.Text);
                            a.Pwd = fx.ValidateName(conf.Text);
                            if (choix.Text.Equals("1"))
                            {
                                if (a.Enregistrer1() == true)
                                {
                                    fx.Message(2);
                                    Actualiser();
                                }
                            }
                            else if (choix.Text.Equals("2"))
                            {
                                if (a.Enregistrer2() == true)
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

        private void Agent_SelectedIndexChanged(object sender, EventArgs e)
        {
            a.IdAgent = pro.IdCombo("Liste_Agent", Agent.Text, "Noms");

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void profil_Click(object sender, EventArgs e)
        {
            fx.ImporterPhoto(profil);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
