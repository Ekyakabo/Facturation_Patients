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
    public partial class FrmFinance : Form
    {
        public FrmFinance()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        ClsFonctions fx = new ClsFonctions();
        private void label5_Click(object sender, EventArgs e)
        {
            AjoutFacture p = new AjoutFacture();
            p.idagent.Text = idagent.Text;
            PanelAffichage.Controls.Clear();
            panelMouve.Height = panel7.Height;
            panelMouve.Top = panel7.Top;
            fx.openChildForm(p, PanelAffichage);
        }

        private void FrmFinance_Load(object sender, EventArgs e)
        {
            AjoutFacture p = new AjoutFacture();
            PanelAffichage.Controls.Clear();
            panelMouve.Height = panel7.Height;
            panelMouve.Top = panel7.Top;
            fx.openChildForm(p, PanelAffichage);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AjoutDepense p = new AjoutDepense();
            p.idagent.Text = idagent.Text;
            PanelAffichage.Controls.Clear();
            panelMouve.Height = panel6.Height;
            panelMouve.Top = panel6.Top;
            fx.openChildForm(p, PanelAffichage);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmValider p = new FrmValider();
            p.idagent.Text = idagent.Text;
            PanelAffichage.Controls.Clear();
            panelMouve.Height = panel3.Height;
            panelMouve.Top = panel3.Top;
            fx.openChildForm(p, PanelAffichage);
        }
    }
}
