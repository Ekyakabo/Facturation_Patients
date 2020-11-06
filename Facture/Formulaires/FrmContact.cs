using Facture.Fonctions;
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
    public partial class FrmContact : Form
    {
        public FrmContact()
        {
            InitializeComponent();
        }

        ClsFonctions fx = new ClsFonctions();
        private void FrmContact_Load(object sender, EventArgs e)
        {

            fx.Picture_Rond(profil);
            fx.Picture_Rond(panel3);
            fx.Picture_Rond(panel2);
            fx.Picture_Rond(panel7);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iTalk_Panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
