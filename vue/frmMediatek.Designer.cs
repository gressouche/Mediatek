﻿
namespace Mediatek86
{
    partial class frmMediatek
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOngletsApplication = new System.Windows.Forms.TabControl();
            this.tabParutions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvParutions = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateParution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTitres = new System.Windows.Forms.ComboBox();
            this.tabTitres = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTitres = new System.Windows.Forms.DataGridView();
            this.idTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomaines = new System.Windows.Forms.ComboBox();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txbTitre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNumDoc = new System.Windows.Forms.TextBox();
            this.tabDVD = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblCollection = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.grpRechercheCode = new System.Windows.Forms.GroupBox();
            this.grpRechercheTitre = new System.Windows.Forms.GroupBox();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lacollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOngletsApplication.SuspendLayout();
            this.tabParutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).BeginInit();
            this.tabTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).BeginInit();
            this.tabLivres.SuspendLayout();
            this.grpRechercheCode.SuspendLayout();
            this.grpRechercheTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOngletsApplication
            // 
            this.tabOngletsApplication.Controls.Add(this.tabParutions);
            this.tabOngletsApplication.Controls.Add(this.tabTitres);
            this.tabOngletsApplication.Controls.Add(this.tabLivres);
            this.tabOngletsApplication.Controls.Add(this.tabDVD);
            this.tabOngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOngletsApplication.Location = new System.Drawing.Point(0, 0);
            this.tabOngletsApplication.Name = "tabOngletsApplication";
            this.tabOngletsApplication.SelectedIndex = 0;
            this.tabOngletsApplication.Size = new System.Drawing.Size(800, 549);
            this.tabOngletsApplication.TabIndex = 0;
            // 
            // tabParutions
            // 
            this.tabParutions.Controls.Add(this.label3);
            this.tabParutions.Controls.Add(this.dgvParutions);
            this.tabParutions.Controls.Add(this.label1);
            this.tabParutions.Controls.Add(this.cbxTitres);
            this.tabParutions.Location = new System.Drawing.Point(4, 22);
            this.tabParutions.Name = "tabParutions";
            this.tabParutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabParutions.Size = new System.Drawing.Size(792, 523);
            this.tabParutions.TabIndex = 0;
            this.tabParutions.Text = "Parutions";
            this.tabParutions.UseVisualStyleBackColor = true;
            this.tabParutions.Enter += new System.EventHandler(this.tabParutions_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Visualisation des numéros reçus par titre";
            // 
            // dgvParutions
            // 
            this.dgvParutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.dateParution,
            this.photo});
            this.dgvParutions.Location = new System.Drawing.Point(88, 135);
            this.dgvParutions.Name = "dgvParutions";
            this.dgvParutions.Size = new System.Drawing.Size(543, 235);
            this.dgvParutions.TabIndex = 2;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            this.numero.Width = 60;
            // 
            // dateParution
            // 
            this.dateParution.HeaderText = "DATE DE PARUTION";
            this.dateParution.Name = "dateParution";
            this.dateParution.Width = 140;
            // 
            // photo
            // 
            this.photo.HeaderText = "EMPLACEMENT PHOTO";
            this.photo.Name = "photo";
            this.photo.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir un titre :";
            // 
            // cbxTitres
            // 
            this.cbxTitres.FormattingEnabled = true;
            this.cbxTitres.Location = new System.Drawing.Point(188, 74);
            this.cbxTitres.Name = "cbxTitres";
            this.cbxTitres.Size = new System.Drawing.Size(146, 21);
            this.cbxTitres.TabIndex = 0;
            this.cbxTitres.SelectedIndexChanged += new System.EventHandler(this.cbxTitres_SelectedIndexChanged);
            // 
            // tabTitres
            // 
            this.tabTitres.Controls.Add(this.label4);
            this.tabTitres.Controls.Add(this.dgvTitres);
            this.tabTitres.Controls.Add(this.label2);
            this.tabTitres.Controls.Add(this.cbxDomaines);
            this.tabTitres.Location = new System.Drawing.Point(4, 22);
            this.tabTitres.Name = "tabTitres";
            this.tabTitres.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitres.Size = new System.Drawing.Size(792, 523);
            this.tabTitres.TabIndex = 1;
            this.tabTitres.Text = "Titres";
            this.tabTitres.UseVisualStyleBackColor = true;
            this.tabTitres.Enter += new System.EventHandler(this.tabTitres_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Visualisation des titres abonnés";
            // 
            // dgvTitres
            // 
            this.dgvTitres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTitre,
            this.nom,
            this.empruntable,
            this.dateFin,
            this.periodicite});
            this.dgvTitres.Location = new System.Drawing.Point(72, 139);
            this.dgvTitres.Name = "dgvTitres";
            this.dgvTitres.Size = new System.Drawing.Size(623, 111);
            this.dgvTitres.TabIndex = 2;
            // 
            // idTitre
            // 
            this.idTitre.HeaderText = "NUMERO";
            this.idTitre.Name = "idTitre";
            this.idTitre.Width = 60;
            // 
            // nom
            // 
            this.nom.HeaderText = "TITRE";
            this.nom.Name = "nom";
            this.nom.Width = 200;
            // 
            // empruntable
            // 
            this.empruntable.HeaderText = "EMPRUNTABLE";
            this.empruntable.Name = "empruntable";
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "FIN D\'ABONNEMENT";
            this.dateFin.Name = "dateFin";
            this.dateFin.Width = 140;
            // 
            // periodicite
            // 
            this.periodicite.HeaderText = "PERIODICITE";
            this.periodicite.Name = "periodicite";
            this.periodicite.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir un domaine :";
            // 
            // cbxDomaines
            // 
            this.cbxDomaines.FormattingEnabled = true;
            this.cbxDomaines.Location = new System.Drawing.Point(208, 77);
            this.cbxDomaines.Name = "cbxDomaines";
            this.cbxDomaines.Size = new System.Drawing.Size(226, 21);
            this.cbxDomaines.TabIndex = 0;
            this.cbxDomaines.SelectedIndexChanged += new System.EventHandler(this.cbxDomaines_SelectedIndexChanged);
            // 
            // tabLivres
            // 
            this.tabLivres.Controls.Add(this.grpRechercheTitre);
            this.tabLivres.Controls.Add(this.grpRechercheCode);
            this.tabLivres.Location = new System.Drawing.Point(4, 22);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Size = new System.Drawing.Size(792, 523);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            this.tabLivres.Enter += new System.EventHandler(this.tabLivres_Enter);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(298, 21);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(96, 20);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txbTitre
            // 
            this.txbTitre.Location = new System.Drawing.Point(236, 18);
            this.txbTitre.Name = "txbTitre";
            this.txbTitre.Size = new System.Drawing.Size(174, 20);
            this.txbTitre.TabIndex = 3;
            this.txbTitre.TextChanged += new System.EventHandler(this.txbTitre_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saisir le titre ou la partie d\'un titre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saisir un numéro de document :";
            // 
            // txbNumDoc
            // 
            this.txbNumDoc.Location = new System.Drawing.Point(207, 22);
            this.txbNumDoc.Name = "txbNumDoc";
            this.txbNumDoc.Size = new System.Drawing.Size(67, 20);
            this.txbNumDoc.TabIndex = 0;
            // 
            // tabDVD
            // 
            this.tabDVD.Location = new System.Drawing.Point(4, 22);
            this.tabDVD.Name = "tabDVD";
            this.tabDVD.Size = new System.Drawing.Size(792, 523);
            this.tabDVD.TabIndex = 3;
            this.tabDVD.Text = "DVD";
            this.tabDVD.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Numéro de document :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Emplacement de l\'image :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Code ISBN :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(233, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Titre :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Auteur(e) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Collection :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(156, 80);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(48, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "(numéro)";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(280, 80);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(30, 13);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "(titre)";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(92, 179);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(58, 13);
            this.lblCollection.TabIndex = 13;
            this.lblCollection.Text = "(collection)";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(295, 146);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(43, 13);
            this.lblAuteur.TabIndex = 14;
            this.lblAuteur.Text = "(auteur)";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(98, 146);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 15;
            this.lblISBN.Text = "(isbn)";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(172, 115);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(41, 13);
            this.lblImage.TabIndex = 16;
            this.lblImage.Text = "(image)";
            // 
            // grpRechercheCode
            // 
            this.grpRechercheCode.Controls.Add(this.btnRechercher);
            this.grpRechercheCode.Controls.Add(this.lblTitre);
            this.grpRechercheCode.Controls.Add(this.lblImage);
            this.grpRechercheCode.Controls.Add(this.label5);
            this.grpRechercheCode.Controls.Add(this.label10);
            this.grpRechercheCode.Controls.Add(this.txbNumDoc);
            this.grpRechercheCode.Controls.Add(this.lblNumero);
            this.grpRechercheCode.Controls.Add(this.lblAuteur);
            this.grpRechercheCode.Controls.Add(this.lblISBN);
            this.grpRechercheCode.Controls.Add(this.label7);
            this.grpRechercheCode.Controls.Add(this.label11);
            this.grpRechercheCode.Controls.Add(this.lblCollection);
            this.grpRechercheCode.Controls.Add(this.label8);
            this.grpRechercheCode.Controls.Add(this.label12);
            this.grpRechercheCode.Controls.Add(this.label9);
            this.grpRechercheCode.Location = new System.Drawing.Point(30, 19);
            this.grpRechercheCode.Name = "grpRechercheCode";
            this.grpRechercheCode.Size = new System.Drawing.Size(723, 206);
            this.grpRechercheCode.TabIndex = 17;
            this.grpRechercheCode.TabStop = false;
            this.grpRechercheCode.Text = "RECHERCHE PAR CODE DOCUMENT";
            // 
            // grpRechercheTitre
            // 
            this.grpRechercheTitre.Controls.Add(this.dgvLivres);
            this.grpRechercheTitre.Controls.Add(this.label6);
            this.grpRechercheTitre.Controls.Add(this.txbTitre);
            this.grpRechercheTitre.Location = new System.Drawing.Point(30, 251);
            this.grpRechercheTitre.Name = "grpRechercheTitre";
            this.grpRechercheTitre.Size = new System.Drawing.Size(723, 264);
            this.grpRechercheTitre.TabIndex = 18;
            this.grpRechercheTitre.TabStop = false;
            this.grpRechercheTitre.Text = "RECHERCHE PAR TITRE";
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoc,
            this.titre,
            this.auteur,
            this.isbn,
            this.lacollection});
            this.dgvLivres.Location = new System.Drawing.Point(18, 62);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.Size = new System.Drawing.Size(689, 180);
            this.dgvLivres.TabIndex = 4;
            // 
            // idDoc
            // 
            this.idDoc.HeaderText = "NUMERO";
            this.idDoc.Name = "idDoc";
            this.idDoc.Width = 60;
            // 
            // titre
            // 
            this.titre.HeaderText = "TITRE DU LIVRE";
            this.titre.Name = "titre";
            this.titre.Width = 200;
            // 
            // auteur
            // 
            this.auteur.HeaderText = "AUTEUR(E)";
            this.auteur.Name = "auteur";
            // 
            // isbn
            // 
            this.isbn.HeaderText = "Code ISBN";
            this.isbn.Name = "isbn";
            this.isbn.Width = 90;
            // 
            // lacollection
            // 
            this.lacollection.HeaderText = "COLLECTION";
            this.lacollection.Name = "lacollection";
            this.lacollection.Width = 200;
            // 
            // frmMediatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.tabOngletsApplication);
            this.Name = "frmMediatek";
            this.Text = "Gestion Médiathèque";
            this.Load += new System.EventHandler(this.frmMediatek_Load);
            this.tabOngletsApplication.ResumeLayout(false);
            this.tabParutions.ResumeLayout(false);
            this.tabParutions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).EndInit();
            this.tabTitres.ResumeLayout(false);
            this.tabTitres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).EndInit();
            this.tabLivres.ResumeLayout(false);
            this.grpRechercheCode.ResumeLayout(false);
            this.grpRechercheCode.PerformLayout();
            this.grpRechercheTitre.ResumeLayout(false);
            this.grpRechercheTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOngletsApplication;
        private System.Windows.Forms.TabPage tabParutions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTitres;
        private System.Windows.Forms.TabPage tabTitres;
        private System.Windows.Forms.ComboBox cbxDomaines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTitres;
        private System.Windows.Forms.DataGridView dgvParutions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateParution;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn empruntable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicite;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.TabPage tabDVD;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txbTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNumDoc;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpRechercheTitre;
        private System.Windows.Forms.GroupBox grpRechercheCode;
        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lacollection;
    }
}

