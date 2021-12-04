
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
            this.dgvParutions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTitres = new System.Windows.Forms.ComboBox();
            this.tabTitres = new System.Windows.Forms.TabPage();
            this.dgvTitres = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomaines = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateParution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.tabDVD = new System.Windows.Forms.TabPage();
            this.tabOngletsApplication.SuspendLayout();
            this.tabParutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).BeginInit();
            this.tabTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).BeginInit();
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
            // tabLivres
            // 
            this.tabLivres.Location = new System.Drawing.Point(4, 22);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Size = new System.Drawing.Size(792, 523);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
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
    }
}

