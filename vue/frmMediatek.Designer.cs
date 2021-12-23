
namespace Mediatek86
{
    partial class FrmMediatek
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
            this.tabTitres = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTitres = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomaines = new System.Windows.Forms.ComboBox();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.grpRechercheTitre = new System.Windows.Forms.GroupBox();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTitre = new System.Windows.Forms.TextBox();
            this.grpRechercheCode = new System.Windows.Forms.GroupBox();
            this.lblRayon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCollection = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabDVD = new System.Windows.Forms.TabPage();
            this.tabReceptionRevue = new System.Windows.Forms.TabPage();
            this.grpParution = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txbImage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpParution = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.grpRevue = new System.Windows.Forms.GroupBox();
            this.btnRechercherRevue = new System.Windows.Forms.Button();
            this.lblTitreRevue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbIdRevue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delaimiseadispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxGenres = new System.Windows.Forms.ComboBox();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lacollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libellegenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPublic = new System.Windows.Forms.Label();
            this.tabOngletsApplication.SuspendLayout();
            this.tabTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).BeginInit();
            this.tabLivres.SuspendLayout();
            this.grpRechercheTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.grpRechercheCode.SuspendLayout();
            this.tabReceptionRevue.SuspendLayout();
            this.grpParution.SuspendLayout();
            this.grpRevue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOngletsApplication
            // 
            this.tabOngletsApplication.Controls.Add(this.tabTitres);
            this.tabOngletsApplication.Controls.Add(this.tabLivres);
            this.tabOngletsApplication.Controls.Add(this.tabDVD);
            this.tabOngletsApplication.Controls.Add(this.tabReceptionRevue);
            this.tabOngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOngletsApplication.ItemSize = new System.Drawing.Size(49, 18);
            this.tabOngletsApplication.Location = new System.Drawing.Point(0, 0);
            this.tabOngletsApplication.Name = "tabOngletsApplication";
            this.tabOngletsApplication.SelectedIndex = 0;
            this.tabOngletsApplication.Size = new System.Drawing.Size(800, 614);
            this.tabOngletsApplication.TabIndex = 0;
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
            this.tabTitres.Text = "Revues";
            this.tabTitres.UseVisualStyleBackColor = true;
            this.tabTitres.Enter += new System.EventHandler(this.tabTitres_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Visualisation des titres de presse";
            // 
            // dgvTitres
            // 
            this.dgvTitres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTitre,
            this.nom,
            this.empruntable,
            this.periodicite,
            this.delaimiseadispo,
            this.genre});
            this.dgvTitres.Location = new System.Drawing.Point(27, 136);
            this.dgvTitres.Name = "dgvTitres";
            this.dgvTitres.Size = new System.Drawing.Size(735, 227);
            this.dgvTitres.TabIndex = 2;
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
            this.tabLivres.Size = new System.Drawing.Size(792, 588);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            this.tabLivres.Enter += new System.EventHandler(this.tabLivres_Enter);
            // 
            // grpRechercheTitre
            // 
            this.grpRechercheTitre.Controls.Add(this.cbxGenres);
            this.grpRechercheTitre.Controls.Add(this.label14);
            this.grpRechercheTitre.Controls.Add(this.dgvLivres);
            this.grpRechercheTitre.Controls.Add(this.label6);
            this.grpRechercheTitre.Controls.Add(this.txbTitre);
            this.grpRechercheTitre.Location = new System.Drawing.Point(8, 251);
            this.grpRechercheTitre.Name = "grpRechercheTitre";
            this.grpRechercheTitre.Size = new System.Drawing.Size(776, 264);
            this.grpRechercheTitre.TabIndex = 18;
            this.grpRechercheTitre.TabStop = false;
            this.grpRechercheTitre.Text = "RECHERCHE PAR TITRE OU PAR GENRE";
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoc,
            this.titre,
            this.auteur,
            this.isbn,
            this.lacollection,
            this.libellegenre});
            this.dgvLivres.Location = new System.Drawing.Point(18, 62);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.Size = new System.Drawing.Size(742, 180);
            this.dgvLivres.TabIndex = 4;
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
            // txbTitre
            // 
            this.txbTitre.Location = new System.Drawing.Point(236, 18);
            this.txbTitre.Name = "txbTitre";
            this.txbTitre.Size = new System.Drawing.Size(174, 20);
            this.txbTitre.TabIndex = 3;
            this.txbTitre.TextChanged += new System.EventHandler(this.txbTitre_TextChanged);
            // 
            // grpRechercheCode
            // 
            this.grpRechercheCode.Controls.Add(this.lblPublic);
            this.grpRechercheCode.Controls.Add(this.label19);
            this.grpRechercheCode.Controls.Add(this.lblRayon);
            this.grpRechercheCode.Controls.Add(this.label1);
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
            this.grpRechercheCode.Location = new System.Drawing.Point(8, 19);
            this.grpRechercheCode.Name = "grpRechercheCode";
            this.grpRechercheCode.Size = new System.Drawing.Size(776, 206);
            this.grpRechercheCode.TabIndex = 17;
            this.grpRechercheCode.TabStop = false;
            this.grpRechercheCode.Text = "RECHERCHE PAR CODE DOCUMENT";
            // 
            // lblRayon
            // 
            this.lblRayon.AutoSize = true;
            this.lblRayon.Location = new System.Drawing.Point(299, 179);
            this.lblRayon.Name = "lblRayon";
            this.lblRayon.Size = new System.Drawing.Size(39, 13);
            this.lblRayon.TabIndex = 18;
            this.lblRayon.Text = "(rayon)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rayon :";
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
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(280, 80);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(30, 13);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "(titre)";
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
            // txbNumDoc
            // 
            this.txbNumDoc.Location = new System.Drawing.Point(207, 22);
            this.txbNumDoc.Name = "txbNumDoc";
            this.txbNumDoc.Size = new System.Drawing.Size(67, 20);
            this.txbNumDoc.TabIndex = 0;
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
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(92, 179);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(58, 13);
            this.lblCollection.TabIndex = 13;
            this.lblCollection.Text = "(collection)";
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
            // tabDVD
            // 
            this.tabDVD.Location = new System.Drawing.Point(4, 22);
            this.tabDVD.Name = "tabDVD";
            this.tabDVD.Size = new System.Drawing.Size(792, 523);
            this.tabDVD.TabIndex = 3;
            this.tabDVD.Text = "DVD";
            this.tabDVD.UseVisualStyleBackColor = true;
            // 
            // tabReceptionRevue
            // 
            this.tabReceptionRevue.Controls.Add(this.grpParution);
            this.tabReceptionRevue.Controls.Add(this.grpRevue);
            this.tabReceptionRevue.Controls.Add(this.label3);
            this.tabReceptionRevue.Location = new System.Drawing.Point(4, 22);
            this.tabReceptionRevue.Name = "tabReceptionRevue";
            this.tabReceptionRevue.Size = new System.Drawing.Size(792, 523);
            this.tabReceptionRevue.TabIndex = 4;
            this.tabReceptionRevue.Text = "Réception Revue";
            this.tabReceptionRevue.UseVisualStyleBackColor = true;
            this.tabReceptionRevue.Enter += new System.EventHandler(this.tabReceptionRevue_Enter);
            // 
            // grpParution
            // 
            this.grpParution.Controls.Add(this.btnValider);
            this.grpParution.Controls.Add(this.txbImage);
            this.grpParution.Controls.Add(this.label18);
            this.grpParution.Controls.Add(this.txbNumero);
            this.grpParution.Controls.Add(this.label17);
            this.grpParution.Controls.Add(this.dtpParution);
            this.grpParution.Controls.Add(this.label16);
            this.grpParution.Location = new System.Drawing.Point(79, 250);
            this.grpParution.Name = "grpParution";
            this.grpParution.Size = new System.Drawing.Size(590, 222);
            this.grpParution.TabIndex = 16;
            this.grpParution.TabStop = false;
            this.grpParution.Text = "Numéro réceptionné";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(56, 165);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(450, 40);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Valider la réception";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txbImage
            // 
            this.txbImage.Location = new System.Drawing.Point(186, 113);
            this.txbImage.Name = "txbImage";
            this.txbImage.Size = new System.Drawing.Size(320, 20);
            this.txbImage.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(53, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Emplacement image :";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(186, 37);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(69, 20);
            this.txbNumero.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(70, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Date de parution :";
            // 
            // dtpParution
            // 
            this.dtpParution.Location = new System.Drawing.Point(186, 73);
            this.dtpParution.Name = "dtpParution";
            this.dtpParution.Size = new System.Drawing.Size(200, 20);
            this.dtpParution.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(122, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Numéro :";
            // 
            // grpRevue
            // 
            this.grpRevue.Controls.Add(this.btnRechercherRevue);
            this.grpRevue.Controls.Add(this.lblTitreRevue);
            this.grpRevue.Controls.Add(this.label13);
            this.grpRevue.Controls.Add(this.label15);
            this.grpRevue.Controls.Add(this.txbIdRevue);
            this.grpRevue.Location = new System.Drawing.Point(79, 90);
            this.grpRevue.Name = "grpRevue";
            this.grpRevue.Size = new System.Drawing.Size(590, 118);
            this.grpRevue.TabIndex = 15;
            this.grpRevue.TabStop = false;
            this.grpRevue.Text = "Revue/Journal";
            // 
            // btnRechercherRevue
            // 
            this.btnRechercherRevue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherRevue.Location = new System.Drawing.Point(253, 25);
            this.btnRechercherRevue.Name = "btnRechercherRevue";
            this.btnRechercherRevue.Size = new System.Drawing.Size(96, 20);
            this.btnRechercherRevue.TabIndex = 8;
            this.btnRechercherRevue.Text = "Rechercher";
            this.btnRechercherRevue.UseVisualStyleBackColor = true;
            this.btnRechercherRevue.Click += new System.EventHandler(this.btnRechercherRevue_Click);
            // 
            // lblTitreRevue
            // 
            this.lblTitreRevue.AutoSize = true;
            this.lblTitreRevue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreRevue.Location = new System.Drawing.Point(169, 69);
            this.lblTitreRevue.Name = "lblTitreRevue";
            this.lblTitreRevue.Size = new System.Drawing.Size(42, 17);
            this.lblTitreRevue.TabIndex = 14;
            this.lblTitreRevue.Text = "(titre)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Identifiant de la revue :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(122, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Titre :";
            // 
            // txbIdRevue
            // 
            this.txbIdRevue.Location = new System.Drawing.Point(169, 25);
            this.txbIdRevue.Name = "txbIdRevue";
            this.txbIdRevue.Size = new System.Drawing.Size(67, 20);
            this.txbIdRevue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Réception d\'un numéro de presse";
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
            // periodicite
            // 
            this.periodicite.HeaderText = "PERIODICITE";
            this.periodicite.Name = "periodicite";
            this.periodicite.Width = 80;
            // 
            // delaimiseadispo
            // 
            this.delaimiseadispo.HeaderText = "DISPONIBILITE (en semaines)";
            this.delaimiseadispo.Name = "delaimiseadispo";
            // 
            // genre
            // 
            this.genre.HeaderText = "DOMAINE";
            this.genre.Name = "genre";
            this.genre.Width = 150;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(435, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Ou sélectionner le genre :";
            // 
            // cbxGenres
            // 
            this.cbxGenres.FormattingEnabled = true;
            this.cbxGenres.Location = new System.Drawing.Point(595, 18);
            this.cbxGenres.Name = "cbxGenres";
            this.cbxGenres.Size = new System.Drawing.Size(165, 21);
            this.cbxGenres.TabIndex = 6;
            this.cbxGenres.SelectedIndexChanged += new System.EventHandler(this.cbxGenres_SelectedIndexChanged);
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
            this.titre.Width = 150;
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
            this.lacollection.Width = 150;
            // 
            // libellegenre
            // 
            this.libellegenre.HeaderText = "GENRE";
            this.libellegenre.Name = "libellegenre";
            this.libellegenre.Width = 150;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(435, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Public :";
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Location = new System.Drawing.Point(491, 179);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(41, 13);
            this.lblPublic.TabIndex = 20;
            this.lblPublic.Text = "(public)";
            // 
            // FrmMediatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.tabOngletsApplication);
            this.Name = "FrmMediatek";
            this.Text = "Gestion Médiathèque Version 4";
            this.Load += new System.EventHandler(this.FrmMediatek_Load);
            this.tabOngletsApplication.ResumeLayout(false);
            this.tabTitres.ResumeLayout(false);
            this.tabTitres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).EndInit();
            this.tabLivres.ResumeLayout(false);
            this.grpRechercheTitre.ResumeLayout(false);
            this.grpRechercheTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.grpRechercheCode.ResumeLayout(false);
            this.grpRechercheCode.PerformLayout();
            this.tabReceptionRevue.ResumeLayout(false);
            this.tabReceptionRevue.PerformLayout();
            this.grpParution.ResumeLayout(false);
            this.grpParution.PerformLayout();
            this.grpRevue.ResumeLayout(false);
            this.grpRevue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOngletsApplication;
        private System.Windows.Forms.TabPage tabTitres;
        private System.Windows.Forms.ComboBox cbxDomaines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTitres;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label lblRayon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabReceptionRevue;
        private System.Windows.Forms.Label lblTitreRevue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRechercherRevue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbIdRevue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpParution;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txbImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpParution;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpRevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn empruntable;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicite;
        private System.Windows.Forms.DataGridViewTextBoxColumn delaimiseadispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.ComboBox cbxGenres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lacollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn libellegenre;
        private System.Windows.Forms.Label lblPublic;
        private System.Windows.Forms.Label label19;
    }
}

