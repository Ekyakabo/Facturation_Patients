using Facture.ClsProprietes;
using Facture.ClsTraitements;
using Facture.Connexion;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmQuestion q = new FrmQuestion();
            q.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Login();
            //Form1 f = new Form1();
            //f.ShowDialog();
            //this.Close();
        }
        DynamicClass d = new DynamicClass();
        Testlogin log = new Testlogin();
        public void Login()
        {
            if (d.loginTest(txtuser.Text, pwd.Text, log) == true)
            {
                Form1 fr = new Form1();
                fr.id.Text = log.Id;
                fr.username.Text = log.NomUser;
                fr.niveau.Text = (log.Niveau).ToString();
                fr.fonction.Text = log.Fonction;
                fr.phone.Text = log.Phone;
                fr.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Le nom ou le mot de passe est incorrect!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Text = "";
                pwd.Text = "";
            }            
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void username_Enter(object sender, EventArgs e)
        {
            
           
        }
        private void username_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void iTalk_RichTextBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void pwd_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void username_MouseLeave_1(object sender, EventArgs e)
        {
            
        }

        private void username_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
        }
    }
}
