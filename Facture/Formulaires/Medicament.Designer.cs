namespace Facture.Formulaires
{
    partial class Medicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicament));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rech = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.resultat = new System.Windows.Forms.Panel();
            this.produit = new System.Windows.Forms.TextBox();
            this.Dosage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.resultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(464, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(73, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 891;
            this.label2.Text = "Designation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Facture.Properties.Resources.Therapy_48px;
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 854;
            this.pictureBox2.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(731, 42);
            this.panel1.TabIndex = 69;
            // 
            // rech
            // 
            this.rech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rech.ForeColor = System.Drawing.Color.DimGray;
            this.rech.Location = new System.Drawing.Point(461, 15);
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
            this.label11.Location = new System.Drawing.Point(186, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 21);
            this.label11.TabIndex = 853;
            this.label11.Text = "Consommation medicament";
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
            this.panel3.Location = new System.Drawing.Point(401, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 30);
            this.panel3.TabIndex = 850;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.Image = global::Facture.Properties.Resources.Checked_32;
            this.save.Location = new System.Drawing.Point(11, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(25, 26);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 883;
            this.save.TabStop = false;
            // 
            // update
            // 
            this.update.Image = global::Facture.Properties.Resources.Uninstalling_Updates_32;
            this.update.Location = new System.Drawing.Point(11, 1);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(25, 26);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 882;
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
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 816;
            this.label1.Text = "Initialiser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(558, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 30);
            this.panel4.TabIndex = 849;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Facture.Properties.Resources.Refresh_32;
            this.pictureBox3.Location = new System.Drawing.Point(8, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 818;
            this.pictureBox3.TabStop = false;
            // 
            // resultat
            // 
            this.resultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultat.BackColor = System.Drawing.Color.White;
            this.resultat.Controls.Add(this.produit);
            this.resultat.Controls.Add(this.Dosage);
            this.resultat.Controls.Add(this.label3);
            this.resultat.Controls.Add(this.label2);
            this.resultat.Controls.Add(this.Table);
            this.resultat.Controls.Add(this.panel4);
            this.resultat.Controls.Add(this.panel3);
            this.resultat.Location = new System.Drawing.Point(0, 47);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(731, 360);
            this.resultat.TabIndex = 70;
            // 
            // produit
            // 
            this.produit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.produit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.ForeColor = System.Drawing.Color.Black;
            this.produit.Location = new System.Drawing.Point(70, 31);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(269, 28);
            this.produit.TabIndex = 895;
            // 
            // Dosage
            // 
            this.Dosage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dosage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dosage.ForeColor = System.Drawing.Color.Black;
            this.Dosage.Location = new System.Drawing.Point(70, 80);
            this.Dosage.Name = "Dosage";
            this.Dosage.Size = new System.Drawing.Size(269, 28);
            this.Dosage.TabIndex = 895;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(73, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 893;
            this.label3.Text = "Dosage";
            // 
            // Table
            // 
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
            this.Table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Table.Location = new System.Drawing.Point(0, 140);
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
            this.Table.Size = new System.Drawing.Size(731, 220);
            this.Table.TabIndex = 626;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultat);
            this.Name = "Medicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicament";
            this.Load += new System.EventHandler(this.Medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.resultat.ResumeLayout(false);
            this.resultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel resultat;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox Dosage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox produit;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}