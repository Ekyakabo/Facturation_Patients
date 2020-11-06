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
    public partial class FrmValider : Form
    {
        public FrmValider()
        {
            InitializeComponent();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void FrmValider_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            ImplementeConnexion.Instance.Initialise();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            Actualiser();
        }
        string a, b, c = "00";
        public void Actualiser()
        {
            a = pro.Montant("Liste_Paiement where id is not null and Etat=1 and DateFac=convert(date,GetDate())", "sum(Paye) ").ToString();
            b = pro.Montant("V_Depense where id is not null and Etat=1 and DateD=convert(date,GetDate())", "sum(isnull(Montant,0)) ").ToString();
            c = (decimal.Parse(mtEntree.Text) - decimal.Parse(mtSortie.Text)).ToString();
            if(!a.Equals(null)|| !b.Equals(null)|| !c.Equals(null))
            {
                mtEntree.Text = a;
                mtSortie.Text = b;
                mtDispo.Text = c;
             }
        }
        Validation op = new Validation();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (fx.Question(1) == true)
                {
                    op.Id = "0";
                    op.IdAgent = idagent.Text;
                    if (radEntree.Checked == true)
                    {
                        op.IdFac = idFac;
                        op.Choix = "1";
                        op.IdDep = "0";
                        if (op.Enregistrer() == true)
                        {
                            fx.Message(1); Actualiser();
                            panel3.Visible = false;
                        }
                    }
                    else if (radSortie.Checked == true)
                    {
                        op.IdFac = "0";
                        op.IdDep = idDep;
                        op.Choix = "2";

                        if (op.Enregistrer() == true)
                        {
                            fx.Message(1);
                            panel3.Visible = false; Actualiser();
                        }
                    }
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void radEntree_CheckedChanged(object sender, EventArgs e)
        {
            Selection();
        }
        public void Selection()
        {
            panel3.Visible = false;
            if (radEntree.Checked==true)
            {
                try
                {

                    Table.DataSource = d.GetTableUsingSql("Liste_Paiement where id is not null and Etat=0");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else if(radSortie.Checked==true)
            {
                try
                {
                    Table.DataSource = d.GetTableUsingSql("V_Depense where id is not null and Etat = 0 ");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void radSortie_CheckedChanged(object sender, EventArgs e)
        {
            Selection();
        }
        string idFac,idDep="0";

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Table_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            if (radEntree.Checked == true)
            {
                try
                {
                    idFac = Table.SelectedCells[0].Value.ToString();

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else if (radSortie.Checked == true)
            {
                try
                {
                    idDep = Table.SelectedCells[0].Value.ToString();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
    }
}
