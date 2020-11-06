namespace Facture.Formulaires
{
    partial class AjoutFacture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutFacture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.montant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.recherche = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idagent = new System.Windows.Forms.Label();
            this.apayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            this.SuspendLayout();
            // 
            // montant
            // 
            this.montant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.ForeColor = System.Drawing.Color.Red;
            this.montant.Location = new System.Drawing.Point(328, 127);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(128, 27);
            this.montant.TabIndex = 883;
            this.montant.TextChanged += new System.EventHandler(this.montant_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(455, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 882;
            this.label4.Text = "USD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(328, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 882;
            this.label7.Text = "Montant payé";
            // 
            // patient
            // 
            this.patient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.FormattingEnabled = true;
            this.patient.Location = new System.Drawing.Point(169, 74);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(312, 25);
            this.patient.TabIndex = 879;
            this.patient.SelectedIndexChanged += new System.EventHandler(this.patient_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.recherche);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 42);
            this.panel1.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Facture.Properties.Resources.Enter_32;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 854;
            this.pictureBox1.TabStop = false;
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
            // recherche
            // 
            this.recherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recherche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.recherche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherche.ForeColor = System.Drawing.Color.DimGray;
            this.recherche.Location = new System.Drawing.Point(592, 15);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(260, 22);
            this.recherche.TabIndex = 47;
            this.recherche.Text = "Tapez ici le mot de Recherche";
            this.recherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            this.recherche.Enter += new System.EventHandler(this.recherche_Enter);
            this.recherche.MouseLeave += new System.EventHandler(this.recherche_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(206, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 21);
            this.label11.TabIndex = 853;
            this.label11.Text = "Enregistrement de paiement";
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
            this.panel3.Location = new System.Drawing.Point(206, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 30);
            this.panel3.TabIndex = 850;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.Image = global::Facture.Properties.Resources.Checked_32;
            this.save.Location = new System.Drawing.Point(7, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(25, 26);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 881;
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
            this.update.TabIndex = 880;
            this.update.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 816;
            this.label1.Text = "Initialiser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle8;
            this.Table.Location = new System.Drawing.Point(5, 290);
            this.Table.Name = "Table";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(852, 287);
            this.Table.TabIndex = 626;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(505, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 30);
            this.panel5.TabIndex = 849;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Facture.Properties.Resources.Print_32;
            this.pictureBox2.Location = new System.Drawing.Point(9, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 587;
            this.pictureBox2.TabStop = false;
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
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(358, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 30);
            this.panel4.TabIndex = 849;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Facture.Properties.Resources.Refresh_32;
            this.pictureBox3.Location = new System.Drawing.Point(9, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 818;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(166, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 876;
            this.label2.Text = "Nom patient";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.idagent);
            this.panel2.Controls.Add(this.apayer);
            this.panel2.Controls.Add(this.montant);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.patient);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Table);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.profil);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 580);
            this.panel2.TabIndex = 66;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // idagent
            // 
            this.idagent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idagent.AutoSize = true;
            this.idagent.BackColor = System.Drawing.Color.Transparent;
            this.idagent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idagent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.idagent.Location = new System.Drawing.Point(791, 232);
            this.idagent.Name = "idagent";
            this.idagent.Size = new System.Drawing.Size(59, 17);
            this.idagent.TabIndex = 884;
            this.idagent.Text = "idagent";
            this.idagent.Visible = false;
            // 
            // apayer
            // 
            this.apayer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apayer.ForeColor = System.Drawing.Color.Red;
            this.apayer.Location = new System.Drawing.Point(169, 130);
            this.apayer.Name = "apayer";
            this.apayer.Size = new System.Drawing.Size(115, 27);
            this.apayer.TabIndex = 883;
            this.apayer.TextChanged += new System.EventHandler(this.montant_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(169, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 882;
            this.label3.Text = "Montant à payer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(288, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 882;
            this.label5.Text = "USD";
            // 
            // profil
            // 
            this.profil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profil.BackColor = System.Drawing.SystemColors.Control;
            this.profil.Image = global::Facture.Properties.Resources.user_image_2;
            this.profil.Location = new System.Drawing.Point(641, 21);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(182, 184);
            this.profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profil.TabIndex = 838;
            this.profil.TabStop = false;
            // 
            // AjoutFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AjoutFacture";
            this.Text = "AjoutFacture";
            this.Load += new System.EventHandler(this.AjoutFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox patient;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox apayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label idagent;
    }
}