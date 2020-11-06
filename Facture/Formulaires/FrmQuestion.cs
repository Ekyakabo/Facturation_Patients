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
    public partial class FrmQuestion : Form
    {
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(reponse.Text.Equals("configuration"))
            {
                if (Connexions.TestFile() == true)
                {
                    FrmConfiguration ser = new FrmConfiguration();
                    ser.choix.Text = "1";
                    this.Close();
                    ser.ShowDialog();
                    

                }
                else
                {
                    FrmConfiguration ser = new FrmConfiguration();
                    ser.choix.Text = "2";
                    ser.ShowDialog();
                }
            }
           else
            {
                MessageBox.Show("Veuillez entrée le mot de passe de configuration ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
