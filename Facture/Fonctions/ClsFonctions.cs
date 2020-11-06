using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MessagingToolkit.QRCode.Codec.Data;

namespace Facture.Fonctions
{
   public  class ClsFonctions
    {
        private static ClsFonctions _instance = null;

        public static ClsFonctions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClsFonctions();
                return _instance;
            }
        }

        public  Form activeForm = null;
        public void openChildForm(Form childForm, Panel panelAffichage)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAffichage.Controls.Add(childForm);
            panelAffichage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
      
        public void CrypterQrCode(PictureBox image,string text)
        {
            try
           { 
             MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
             encode.QRCodeScale = 8;
             Bitmap bmp = encode.Encode(text);
             image.Image = bmp;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

         }
       public string  DecrypterQrCode(PictureBox image, string text)
        {
            string texte = "";
            try
            {
                image.Image = Image.FromFile(text);
                MessagingToolkit.QRCode.Codec.QRCodeDecoder decode = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                text = decode.Decode(new QRCodeBitmapImage(image.Image as Bitmap));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
       
          return texte;
        }
        public void ProprieteDatagrid(DataGridView data)
        {
            data.BorderStyle = BorderStyle.None;
            data.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data.DefaultCellStyle.SelectionBackColor = Color.Silver;
            data.BackgroundColor = Color.White;
            data.ColumnHeadersHeight = 20;
            data.EnableHeadersVisualStyles = false;
            data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 155, 167);
            data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void Picture_Rond(PictureBox p)
        {
            System.Drawing.Drawing2D.GraphicsPath gd = new System.Drawing.Drawing2D.GraphicsPath();
            gd.AddEllipse(0, 0, p.Width - 3, p.Height - 3);
            System.Drawing.Region rg = new Region(gd);
            p.Region = rg;
        }
        public void Picture_Rond(Panel p)
        {
            System.Drawing.Drawing2D.GraphicsPath gd = new System.Drawing.Drawing2D.GraphicsPath();
            gd.AddEllipse(0, 0, p.Width - 3, p.Height - 3);
            System.Drawing.Region rg = new Region(gd);
            p.Region = rg;
        }
        int nbrfois = 0;
        public int occurrence(DataGridView table, string code)
        {
            string id;
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                id = (table.Rows[i].Cells[0].Value.ToString());
                if (id == code)
                {
                    nbrfois = +1;
                }
            }
            return nbrfois;
        }
        public void ajouterDatagrid(DataGridView dt, string id, string design,decimal prix, int qte)
        {
            try
            {
                if (design.Equals("") || qte.Equals(""))
                {
                    MessageBox.Show("Veuilez completer les champs !");
                }
                else
                {
                    dt.Rows.Add(id, design,prix, qte);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public void ajouterDatagrid2(DataGridView dt, string id, string design, string datefab, string dateExp, int qte, decimal prix)
        {
            try
            {
                if (design.Equals("") || qte.Equals(""))
                {
                    MessageBox.Show("Veuilez completer les champs !");
                }
                else
                {
                    dt.Rows.Add(id, design, datefab,dateExp,qte,prix);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public void ChargerUserControl(Panel panel, UserControl user)
        {
            panel.Controls.Clear();
            panel.Controls.Add(user);
            panel.Show();
        }
        public void InitialiserDatagrid(DataGridView table)
        {
            int x = table.Rows.Count - 2;
            for (int y = 0; y < x; y++)
            {
                table.Rows.RemoveAt(y);
            }
        }
        int ligne;
        public void SupprimerDatagrid(DataGridView table)
        {
            string indexe = table.CurrentRow.Index.ToString();
            ligne = int.Parse(indexe);
            table.Rows.RemoveAt(ligne);
        }
        string nomFichier = "";
        public void ImporterPhoto(PictureBox photo)
        {
            OpenFileDialog fl = new OpenFileDialog();
            //fl.InitialDirectory("","");
            fl.Filter = "(Photos)|*.jpg;*.jpeg;*.ico|(Photo png)|*.png|(Toutes)|*.*";
            fl.ShowDialog();
            nomFichier = fl.FileName.ToString();
            photo.ImageLocation = nomFichier;
        }
        public byte[] RetournerBytePhoto(Image image)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(image, typeof(byte[]));
            return arr;
        }
        public string Message(int choix)
        {
            string message = "";
            switch (choix)
            {
                case 1: MessageBox.Show(" Insertion reuçi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                case 2: MessageBox.Show("La modification reuçi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                case 3: MessageBox.Show("La suppression reuçi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }
            return message;
        }
        public void MouseLeave(DataGridView data,string text)
        {
            if (text == "")
            {
               text = "Tapez ici le mot de Recherche"; data.Focus();
            }
        }
        public void MouseEnter(DataGridView data, string text)
        {
            if (text == "Tapez ici le mot de Recherche")
            {
                text = ""; 
            }
        }
        public string Erreur(int choix)
        {
            string message = "";
            switch (choix)
            {
                case 1: MessageBox.Show(" Echec de l'insertion !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 2: MessageBox.Show("Echec de la modification !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 3: MessageBox.Show("Echec de la suppression !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            return message;
        }
        public bool Question(int choix)
        {
            bool test = false;
            switch (choix)
            {
                case 1:
                    DialogResult dr = MessageBox.Show("Voulez vous enregistré?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("L'enregistrement annulé !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;
                case 2:
                    DialogResult rp = MessageBox.Show("Voulez vous modifié ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rp.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("La modification annulée annulé !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;

                case 3:
                    DialogResult r = MessageBox.Show("Voulez vous supprimé?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("La suppression annulée !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;
                case 4:
                    DialogResult imp = MessageBox.Show("Voulez vous imprimé ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (imp.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("L'impression annulé !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;
            }
            return test;

        }
        public string ValidateName(string nom)
        {
            if (!string.IsNullOrEmpty(nom))
            {
                nom = nom.ToLower();
                return nom[0].ToString().ToUpper() + new string(nom.ToCharArray(), 1, nom.Length - 1);
                /*  if (!char.IsLetter(nom[0]))
                      throw new InvalidOperationException("Le nom ou le mot doit commencer par une letter !!!");
                  else
                  {
                      nom = nom.ToLower();
                      return nom[0].ToString().ToUpper() + new string(nom.ToCharArray(), 1, nom.Length - 1);
                  }
                  */
            }
            else
                throw new InvalidOperationException("Le nom ou le mot doit avoir une valeur !!!");
        }
        public string  Matricule(string nom)
        {
            try
            {
                if (!string.IsNullOrEmpty(nom))
                {
                    nom = nom.ToUpper();
                    return nom[0].ToString().ToUpper() + new string(nom.ToCharArray(), 1, nom.Length - 7);

                }
                else
                    throw new InvalidOperationException("Le nom ou le mot doit avoir une valeur !!!");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public void ErrorProvide(ErrorProvider err, TextBox valeur)
        {
            int val = 0;
            try
            {
                if (!int.TryParse(valeur.Text, out val))
                {
                    err.SetError(valeur, "Entrez un nombre svp!");
                    valeur.Text = "";
                }
                else
                {
                    if (int.Parse(valeur.Text) < 0)
                        valeur.Text = "";                    
                    else
                        err.SetError(valeur, "");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Verifier_Numerique(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public void Verifier_Character(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
      
        
    }
}
