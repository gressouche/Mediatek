using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mediatek86.metier;
using Mediatek86.controleur;


namespace Mediatek86
{
    public partial class FrmMediatek : Form
    {
        #region Variables globales
        /// <summary>
        /// instance du controleur
        /// </summary>
        private readonly Controle controle;

        /// <summary>
        /// Collections pour stocker les objets
        /// </summary>
        List<Categorie> lesCategories;
        List<Genre> lesGenres;
        List<Revue> lesRevues;
        List<Rayon> lesRayons;
        List<Livre> lesLivres;
        List<Categorie> lesPublics;
        List<Exemplaire> lesExemplairesParRevue;
        Revue laRevue;

        #endregion


        #region Formulaire

        internal FrmMediatek(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Au lancement du formulaire, on charge des objets en mémoire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediatek_Load(object sender, EventArgs e)
        {
            // Chargement des objets en mémoire
            lesGenres = controle.getAllGenres();
            lesRevues = controle.getLesRevues();

            // Affectation du Domaine ou Genre à chaque Titre
            foreach (Revue revue in lesRevues)
            {
                Genre genreDeLaRevue = controle.getGenreByRevue(revue);
                revue.LeGenre = genreDeLaRevue;
            }
        }

        #endregion


        #region Revues
        //-----------------------------------------------------------
        // ONGLET "Revues"
        //------------------------------------------------------------

        /// <summary>
        /// Ouverture de l'onglet : on renseigne la liste déroulante et
        /// on remplit le DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabTitres_Enter(object sender, EventArgs e)
        {
            // Chargement de la liste déroulante à partir de la collection des Domaines
            cbxDomaines.DataSource = lesGenres;
            cbxDomaines.DisplayMember = "libelle";
            cbxDomaines.Text = "";

            // On affiche d'abord tous les titres auxquels est abonnée la médiathèque
            dgvTitres.Rows.Clear();
            foreach (Revue revue in lesRevues)
            {
                dgvTitres.Rows.Add(revue.IdDoc, revue.Titre, revue.Empruntable, revue.Periodicite, revue.DelaiMiseADispo, revue.LeGenre.Libelle);
            }
        }


        /// <summary>
        /// Sélection d'un domaine dans la liste déroulante : on cahrge le datagridview
        /// avec les Titres liés au Domaine sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDomaines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Objet Genre sélectionné dans la comboBox
            Genre genreSelectionne = (Genre)cbxDomaines.SelectedItem;

            // ré-initialisation du dataGridView
            dgvTitres.Rows.Clear();

            // Parcours de la collection des titres et alimentation du datagridview
            // On n'affiche que les revues correspondant au domaine choisi
            foreach (Revue revue in lesRevues)
            {
                if (revue.LeGenre.IdGenre == genreSelectionne.IdGenre)
                {
                    dgvTitres.Rows.Add(revue.IdDoc, revue.Titre, revue.Empruntable, revue.Periodicite, revue.DelaiMiseADispo, revue.LeGenre.Libelle);
                }
            }
        }


        /// <summary>
        /// Bouton qui annule le filtre sur les domaines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTousDomaines_Click(object sender, EventArgs e)
        {
            // On affiche tous les titres auxquels est abonnée la médiathèque
            dgvTitres.Rows.Clear();
            foreach (Revue revue in lesRevues)
            {
                dgvTitres.Rows.Add(revue.IdDoc, revue.Titre, revue.Empruntable, revue.Periodicite, revue.DelaiMiseADispo, revue.LeGenre.Libelle);
            }
            cbxDomaines.Text = "";
        }
        #endregion


        #region Livres
        //-----------------------------------------------------------
        // ONGLET "LIVRES"
        //-----------------------------------------------------------

        /// <summary>
        /// Ouverture de l'onglet Livres : 
        /// - chargement des catégories, genres et livres en mémoire
        /// - affectation des références de ces objets à chaque Livre
        /// - alimentation des listes déroulantes
        /// - affichage de la liste des livres non filtrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabLivres_Enter(object sender, EventArgs e)
        {
            // Chargement des objets en mémoire
            lesCategories = controle.getAllCategories();
            lesGenres = controle.getAllGenres();
            lesLivres = controle.getAllLivres();
            lesRayons = controle.getAllRayons();
            lesPublics = controle.getAllPublics();

            // Affectation de la catégorie de public, du genre et du rayon à chaque Livre
            foreach (Livre livre in lesLivres)
            {
                Categorie categorie = controle.getCategorieByLivre(livre);
                Genre genreDuLivre = controle.getGenreByLivre(livre);
                Rayon rayon = controle.getRayonByLivre(livre);
                livre.LaCategorie = categorie;
                livre.LeGenre = genreDuLivre;
                livre.LeRayon = rayon;
            }

            // On cache le pictureBox car pas d'image à afficher
            pbxImage.Hide();

            // On renseigne les listes déroulantes des genres, publics et rayons
            cbxGenres.DataSource = lesGenres;
            cbxGenres.DisplayMember = "libelle";
            cbxPublics.DataSource = lesPublics;
            cbxPublics.DisplayMember = "libelle";           
            cbxRayons.DataSource = lesRayons;
            cbxRayons.DisplayMember = "libelle";
            cbxRayons.Text = "";
            cbxGenres.Text = "";
            cbxPublics.Text = "";

            // A l'ouverture de l'onglet, on renseigne le datagrid avec l'ensemble des livres
            dgvLivres.Rows.Clear();
            foreach (Livre livre in lesLivres)
            {
                dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN, livre.LaCollection, livre.LeGenre.Libelle);
            }

        }

        /// <summary>
        /// Recherche et affichage du livre dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // On réinitialise les labels
            lblNumero.Text = "";
            lblTitre.Text = "";
            lblAuteur.Text = "";
            lblCollection.Text = "";
            lblISBN.Text = "";
            lblImage.Text = "";
            lblRayon.Text = "";
            lblPublic.Text = "";

            // On recherche le livre correspondant au numéro de document saisi.
            // S'il n'existe pas: on affiche un popup message d'erreur
            bool trouve = false;
            foreach (Livre livre in lesLivres)
            {
                if (livre.IdDoc == txbNumDoc.Text)
                {
                    lblNumero.Text = livre.IdDoc;
                    lblTitre.Text = livre.Titre;
                    lblAuteur.Text = livre.Auteur;
                    lblCollection.Text = livre.LaCollection;
                    lblISBN.Text = livre.ISBN;
                    lblImage.Text = livre.Image;
                    lblRayon.Text = livre.LeRayon.Libelle;
                    lblPublic.Text = livre.LaCategorie.Libelle;
                    pbxImage.ImageLocation = livre.Image;
                    pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxImage.Show();
                    trouve = true;
                }
            }
            if (!trouve)
                MessageBox.Show("Document non trouvé dans les livres");
        }

        /// <summary>
        /// Recherche et affichage des livres dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTitre_TextChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();
            cbxGenres.Text = "";

            // On parcourt tous les livres. Si le titre matche avec la saisie, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                // on passe le champ de saisie et le titre en minuscules car la méthode Contains
                // tient compte de la casse.
                string saisieMinuscules;
                saisieMinuscules = txbTitre.Text.ToLower();
                string titreMinuscules;
                titreMinuscules = livre.Titre.ToLower();

                //on teste si le titre du livre contient ce qui a été saisi
                if (titreMinuscules.Contains(saisieMinuscules))
                {
                    dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN, livre.LaCollection, livre.LeGenre.Libelle);
                }
            }
        }

        /// <summary>
        /// Filtre sur le genre pour afficher la liste des livres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();

            if (cbxGenres.SelectedItem==null)
            {
                MessageBox.Show("Aucun résultat");
                return;
            }

            // On parcourt tous les livres. Si le livre correspond au genre sélectionné, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                if (livre.LeGenre.Libelle == ((Genre)cbxGenres.SelectedItem).Libelle)
                {
                    dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN, livre.LaCollection, livre.LeGenre.Libelle);
                }
            }

            // On n'affiche rien dans les autres combobox
            cbxPublics.Text = "";
            cbxRayons.Text = "";
        }

        /// <summary>
        /// Filtre sur la catégorie de public pour la liste des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();

            // On parcourt tous les livres. Si le livre correspond au public sélectionné, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                if (livre.LaCategorie.Libelle == ((Categorie)cbxPublics.SelectedItem).Libelle)
                {
                    dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN, livre.LaCollection, livre.LeGenre.Libelle);
                }
            }

            // On n'affiche rien dans les autres combobox
            cbxGenres.Text = "";
            cbxRayons.Text = "";
        }

        /// <summary>
        /// Filtre sur le rayon pour la liste des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();

            // On parcourt tous les livres. Si le livre correspond au rayon sélectionné, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                if (livre.LeRayon.Libelle == ((Rayon)cbxRayons.SelectedItem).Libelle)
                {
                    dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN, livre.LaCollection, livre.LeGenre.Libelle);
                }
            }

            // On n'affiche rien dans les autres combobox
            cbxPublics.Text = "";
            cbxGenres.Text = "";
        }

        #endregion


        #region Réception Exemplaire de presse
        //-----------------------------------------------------------
        // ONGLET "RECEPTION DE REVUES"
        //-----------------------------------------------------------

        /// <summary>
        /// Ouverture de l'onglet : blocage en saisie des champs de saisie des infos de l'exemplaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabReceptionRevue_Enter(object sender, EventArgs e)
        {
            txbNumero.Enabled = false;
            txbImage.Enabled = false;
            dtpParution.Enabled = false;
            btnValider.Enabled = false;
        }

        /// <summary>
        /// Après sélection d'un identifiant de revue, on rechereche les exemplaires existants de cette revue.
        /// - si la revue n'est pas trouvée : affichage d'un MessageBox
        /// - si trouvée : constitution d'une collection d'objets Exemplaire, et déblocage des champs
        /// permettant la saisie des infos du nouvel exemplaire à créer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercherRevue_Click(object sender, EventArgs e)
        {
            bool trouve = false;

            foreach (Revue revue in lesRevues)
            {
                if (revue.IdDoc == txbIdRevue.Text)
                {
                    trouve = true;
                    lblTitreRevue.Text = revue.Titre;
                    lesExemplairesParRevue = controle.getLesExemplairesByRevue(revue);
                    laRevue = revue;
                }
            }
            if (!trouve)
            {
                lblTitreRevue.Text = "";
                MessageBox.Show("Revue non trouvée");
            }
            else
            {
                txbNumero.Enabled = true;
                txbImage.Enabled = true;
                dtpParution.Enabled = true;
                btnValider.Enabled = true;
                txbNumero.Text = "";
                txbImage.Text = "";
                dtpParution.Text = "";
            }
        }

        /// <summary>
        /// Validation de la saisie des infos :
        /// - vérification que le numéro saisi est numérique
        /// - instanciation d'un objet Exemplaire
        /// - appel du contrôleur pour crézr l'exemplaire en bdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            int numParution;
            try
            {
                numParution = int.Parse(txbNumero.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Numéro saisi non numérique");
                return;
            }

            Exemplaire exemplaireACreer = new Exemplaire(numParution, dtpParution.Value, txbImage.Text, "00001");
            exemplaireACreer.Document = laRevue.getInstanceDocument();

            try
            {
                controle.creerExemplaire(exemplaireACreer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout en bdd - " + ex.Message);
                return;
            }
            MessageBox.Show("Ajout en bdd ok");
        }



        #endregion

        /*private void cbxGenres_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Action interdite");
        }
        */
    }
}
