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
    public partial class FrmDashbord : Form
    {
        public FrmDashbord()
        {
            InitializeComponent();
        }
        ProprietePublique pro = new ProprietePublique();
        DynamicClass d = new DynamicClass();
        ClsFonctions fx = new ClsFonctions();
        private void FrmDashbord_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            nbragent.Text = pro.NbreEnregistrement("Agent", "count(Id)").ToString();
            NbrePatient.Text = pro.NbreEnregistrement("Patient where id is not null", "count(Id)").ToString();
            NbreConsultation.Text = pro.NbreEnregistrement("Liste_consultation", "count(Id)").ToString();
            examine.Text = pro.NbreEnregistrement("liste_Examen", "count(Id)").ToString();

            entree.Text = pro.NbreEnregistrement("Appro_Medicament", "sum(Qte) ").ToString();
            sortie.Text = pro.NbreEnregistrement("Liste_Consommation where id is not null", "sum(Qte)").ToString();
            stockDispo.Text = (int.Parse(entree.Text) - int.Parse(sortie.Text)).ToString();

            try
            {
                chart1.Series["Entree"].IsValueShownAsLabel = true;
                d.Graphique(chart1, "Entree", "select Qte from Appro_Medicament ", "Produit", "Qte");

                chart1.Series["Sortie"].IsValueShownAsLabel = true;
                d.Graphique(chart1, "Sortie", "select Qte from Liste_Consommation ", "Patient", "Qte");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            fx.Picture_Rond(pan1);
            fx.Picture_Rond(pan2);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateP.Text = DateTime.Now.ToString("yyyy/MM/dd");
            heure.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            dateP.Text = DateTime.Now.ToString("yyyy/MM/dd");
            heure.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
