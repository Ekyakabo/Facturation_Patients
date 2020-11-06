namespace Facture.Formulaires
{
    partial class AjoutExamen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutExamen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rech = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultat = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idagent = new System.Windows.Forms.Label();
            this.tarif = new System.Windows.Forms.ComboBox();
            this.patient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new iTalk.iTalk_RichTextBox();
            this.symptome = new iTalk.iTalk_RichTextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            this.profil = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.resultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.rech);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 42);
            this.panel1.TabIndex = 65;
            // 
            // rech
            // 
            this.rech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rech.ForeColor = System.Drawing.Color.DimGray;
            this.rech.Location = new System.Drawing.Point(592, 15);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(260, 22);
            this.rech.TabIndex = 47;
            this.rech.Text = "Tapez ici le mot de Recherche";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.rech_TextChanged);
            this.rech.Enter += new System.EventHandler(this.rech_Enter);
            this.rech.MouseLeave += new System.EventHandler(this.rech_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(206, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 21);
            this.label11.TabIndex = 853;
            this.label11.Text = "Enregistrement examen";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(40, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 20);
            this.btnSave.TabIndex = 816;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel3.Controls.Add(this.save);
            this.panel3.Controls.Add(this.update);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(295, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 30);
            this.panel3.TabIndex = 850;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 816;
            this.label1.Text = "Initialiser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(304, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 852;
            this.label6.Text = "Resultat";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(452, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 30);
            this.panel4.TabIndex = 849;
            // 
            // resultat
            // 
            this.resultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultat.BackColor = System.Drawing.Color.White;
            this.resultat.Controls.Add(this.panel5);
            this.resultat.Controls.Add(this.label4);
            this.resultat.Controls.Add(this.montant);
            this.resultat.Controls.Add(this.label5);
            this.resultat.Controls.Add(this.idagent);
            this.resultat.Controls.Add(this.tarif);
            this.resultat.Controls.Add(this.patient);
            this.resultat.Controls.Add(this.label2);
            this.resultat.Controls.Add(this.result);
            this.resultat.Controls.Add(this.symptome);
            this.resultat.Controls.Add(this.Table);
            this.resultat.Controls.Add(this.label7);
            this.resultat.Controls.Add(this.label3);
            this.resultat.Controls.Add(this.label6);
            this.resultat.Controls.Add(this.panel4);
            this.resultat.Controls.Add(this.panel3);
            this.resultat.Controls.Add(this.profil);
            this.resultat.Location = new System.Drawing.Point(0, 48);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(862, 580);
            this.resultat.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(537, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 885;
            this.label4.Text = "USD";
            // 
            // montant
            // 
            this.montant.AutoSize = true;
            this.montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.ForeColor = System.Drawing.Color.Red;
            this.montant.Location = new System.Drawing.Point(474, 197);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(27, 20);
            this.montant.TabIndex = 884;
            this.montant.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(464, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 883;
            this.label5.Text = "Type consultation";
            // 
            // idagent
            // 
            this.idagent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idagent.AutoSize = true;
            this.idagent.BackColor = System.Drawing.Color.Transparent;
            this.idagent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idagent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.idagent.Location = new System.Drawing.Point(787, 235);
            this.idagent.Name = "idagent";
            this.idagent.Size = new System.Drawing.Size(59, 17);
            this.idagent.TabIndex = 882;
            this.idagent.Text = "idagent";
            this.idagent.Visible = false;
            // 
            // tarif
            // 
            this.tarif.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarif.FormattingEnabled = true;
            this.tarif.Location = new System.Drawing.Point(300, 149);
            this.tarif.Name = "tarif";
            this.tarif.Size = new System.Drawing.Size(283, 25);
            this.tarif.TabIndex = 881;
            this.tarif.SelectedIndexChanged += new System.EventHandler(this.tarif_SelectedIndexChanged);
            // 
            // patient
            // 
            this.patient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.FormattingEnabled = true;
            this.patient.Location = new System.Drawing.Point(27, 35);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(269, 25);
            this.patient.TabIndex = 880;
            this.patient.SelectedIndexChanged += new System.EventHandler(this.patient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 879;
            this.label2.Text = "Nom patient";
            // 
            // result
            // 
            this.result.AutoWordSelection = false;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Tahoma", 10F);
            this.result.ForeColor = System.Drawing.Color.DimGray;
            this.result.Location = new System.Drawing.Point(302, 29);
            this.result.Name = "result";
            this.result.ReadOnly = false;
            this.result.Size = new System.Drawing.Size(281, 100);
            this.result.TabIndex = 861;
            this.result.WordWrap = true;
            // 
            // symptome
            // 
            this.symptome.AutoWordSelection = false;
            this.symptome.BackColor = System.Drawing.Color.Transparent;
            this.symptome.Enabled = false;
            this.symptome.Font = new System.Drawing.Font("Tahoma", 10F);
            this.symptome.ForeColor = System.Drawing.Color.DimGray;
            this.symptome.Location = new System.Drawing.Point(25, 83);
            this.symptome.Name = "symptome";
            this.symptome.ReadOnly = false;
            this.symptome.Size = new System.Drawing.Size(267, 149);
            this.symptome.TabIndex = 861;
            this.symptome.WordWrap = true;
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table.Location = new System.Drawing.Point(7, 272);
            this.Table.Name = "Table";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(839, 305);
            this.Table.TabIndex = 626;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(22, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 854;
            this.label7.Text = "Symptome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(299, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 852;
            this.label3.Text = "Type examen";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(604, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 30);
            this.panel5.TabIndex = 886;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(40, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 816;
            this.label15.Text = "Imprimer";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Facture.Properties.Resources.Therapy_48px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 854;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(595, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Facture.Properties.Resources.Print_32;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 587;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Facture.Properties.Resources.Refresh_32;
            this.pictureBox3.Location = new System.Drawing.Point(8, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 817;
            this.pictureBox3.TabStop = false;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.Image = global::Facture.Properties.Resources.Checked_32;
            this.save.Location = new System.Drawing.Point(7, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(25, 26);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 879;
            this.save.TabStop = false;
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.update.Image = global::Facture.Properties.Resources.Uninstalling_Updates_32;
            this.update.Location = new System.Drawing.Point(7, 1);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(25, 26);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 878;
            this.update.TabStop = false;
            // 
            // profil
            // 
            this.profil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profil.BackColor = System.Drawing.SystemColors.Control;
            this.profil.Image = global::Facture.Properties.Resources.user_image_2;
            this.profil.Location = new System.Drawing.Point(641, 24);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(158, 163);
            this.profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profil.TabIndex = 838;
            this.profil.TabStop = false;
            // 
            // AjoutExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultat);
            this.Name = "AjoutExamen";
            this.Text = "AjoutExamen";
            this.Load += new System.EventHandler(this.AjoutExamen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.resultat.ResumeLayout(false);
            this.resultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.Label btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel resultat;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label7;
        private iTalk.iTalk_RichTextBox result;
        private iTalk.iTalk_RichTextBox symptome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox tarif;
        public System.Windows.Forms.Label idagent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label montant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}