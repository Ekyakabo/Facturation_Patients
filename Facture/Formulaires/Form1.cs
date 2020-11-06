using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facture.Fonctions;
using Facture.Formulaires;
using Facture.ClsTraitements;

namespace Facture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsFonctions fx = new ClsFonctions();
        private void AjoutPersonne_Click(object sender, EventArgs e)
        {
            FrmEnregistrement p = new FrmEnregistrement();
            panelMouve.Height = AjoutPersonne.Height;
            panelMouve.Top = AjoutPersonne.Top;
            p.idagent.Text = id.Text;
            p.niveau.Text = niveau.Text;
            fx.openChildForm(p, afficher);
        }
        DynamicClass d = new DynamicClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            FrmDashbord p = new FrmDashbord();
            panelMouve.Height = picturedash.Height;
            panelMouve.Top = picturedash.Top;
            fx.openChildForm(p, afficher);
            fx.Picture_Rond(profil);
            fx.Picture_Rond(panel3);
            conect.Text = fonction.Text;
            d.RetournerPhotoSQl("Profil", "Liste_Agent", "Id", id.Text, profil);
        }
        private void produit_Click(object sender, EventArgs e)
        {
           
        }
        private void finance_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                    FrmFinance p = new FrmFinance();
                    p.idagent.Text = id.Text;
                    panelMouve.Height = finance.Height;
                    panelMouve.Top = finance.Top;
                    fx.openChildForm(p, afficher);

                    break;
                case "2":

                    FrmFinance f = new FrmFinance();
                    f.idagent.Text = id.Text;
                    panelMouve.Height = finance.Height;
                    panelMouve.Top = finance.Top;
                    fx.openChildForm(f, afficher);

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                    FrmConfiguration p = new FrmConfiguration();
                    p.choix.Text = "2";
                    panelMouve.Height = pictureBox1.Height;
                    panelMouve.Top = pictureBox1.Top;
                    fx.openChildForm(p, afficher);

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }
        private void picturedash_Click(object sender, EventArgs e)
        {
            FrmDashbord p = new FrmDashbord();
            panelMouve.Height = picturedash.Height;
            panelMouve.Top = picturedash.Top;
            fx.openChildForm(p, afficher);
            
        }
        private void operation_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            l.Show();
            this.Close();
        }

        private void rapport_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                    FrmStatistique p = new FrmStatistique();
                    panelMouve.Height = rapport.Height;
                    panelMouve.Top = rapport.Top;
                    fx.openChildForm(p, afficher);

                    break;
                case "2":
                    FrmStatistique s = new FrmStatistique();
                    panelMouve.Height = rapport.Height;
                    panelMouve.Top = rapport.Top;
                    fx.openChildForm(s, afficher);

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }

        }

        private void profil_Click(object sender, EventArgs e)
        {
            FrmContact cont = new FrmContact();
            d.RetournerPhotoSQl("Profil", "Liste_Agent", "Id", id.Text, cont.profil);
            cont.nom.Text = username.Text;
            cont.fonction.Text = fonction.Text;
            cont.phone.Text = phone.Text;
            cont.ShowDialog();
        }
    }
}
