using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek86.bdd;
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
        static List<Categorie> lesCategories;
        static List<Genre> lesGenres;
        static List<Revue> lesRevues;
        static List<Rayon> lesRayons;
        static List<Livre> lesLivres;
        static List<Exemplaire> lesExemplairesParRevue;
        static Revue laRevue;

        #endregion


        #region Formulaire

        internal FrmMediatek(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Au lancement du formulaire, on crée la connection à la base de données et 
        /// on charge des objets en mémoire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediatek_Load(object sender, EventArgs e)
        {
            // Création de la connexion avec la base de données
            controle.creerConnectionBDD();

            // Chargement des objets en mémoire
            lesGenres = controle.getAllGenres();
            lesRevues = controle.GetLesRevues();

            // Affectation du Domaine à chaque Titre
            foreach (Revue revue in lesRevues)
            {
                Genre genre = DAOPresse.getGenreByRevue(revue);
                revue.LeGenre = genre;
            }
        }

        #endregion


        #region Revues
        //-----------------------------------------------------------
        // ONGLET "Revues"
        //------------------------------------------------------------
        private void tabTitres_Enter(object sender, EventArgs e)
        {
            // Chargement de la liste déroulante à partir de la collection des Domaines
            cbxDomaines.DataSource = lesGenres;
            cbxDomaines.DisplayMember = "libelle";
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
            foreach (Revue titre in lesRevues)
            {
                if (titre.LeGenre.IdGenre == genreSelectionne.IdGenre)
                {
                    dgvTitres.Rows.Add(titre.IdDoc, titre.Titre, titre.Empruntable, titre.Periodicite, titre.DelaiMiseADispo);
                }
            }
        }
        #endregion


        #region Livres
        //-----------------------------------------------------------
        // ONGLET "LIVRES"
        //-----------------------------------------------------------

        /// <summary>
        /// Ouverture de l'onglet Livres : chargement des catégories, genres et livres an mémoire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabLivres_Enter(object sender, EventArgs e)
        {
            // Chargement des objets en mémoire
            lesCategories = DAODocuments.getAllCategories();
            lesGenres = DAODocuments.getAllGenres();
            lesLivres = DAODocuments.getAllLivres();
            lesRayons = DAODocuments.getAllRayons();

            // Affectation de la catégorie de public à chaque Livre
            foreach (Livre livre in lesLivres)
            {
                Categorie categorie = DAODocuments.getCategorieByLivre(livre);
                Genre genre = DAODocuments.getGenreByLivre(livre);
                Rayon rayon = DAODocuments.getRayonByLivre(livre);
                livre.LaCategorie = categorie;
                livre.LeGenre = genre;
                livre.LeRayon = rayon;
            }

            // Affectation du genre à chaque Livre
            /*foreach (Livre livre in lesLivres)
            {
                Genre genre = DAODocuments.getGenreByLivre(livre);
                livre.LeGenre = genre;
            }*/
        }

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
                    trouve = true;
                }
            }
            if (!trouve)
                MessageBox.Show("Document non trouvé dans les livres");
        }

        private void txbTitre_TextChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();

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
                    dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN, livre.LaCollection);
                }
            }
        }
        #endregion


        #region Réception Exemplaire de presse
        private void tabReceptionRevue_Enter(object sender, EventArgs e)
        {
            txbNumero.Enabled = false;
            txbImage.Enabled = false;
            dtpParution.Enabled = false;
            btnValider.Enabled = false;
        }


        private void btnRechercherRevue_Click(object sender, EventArgs e)
        {
            bool trouve = false;

            foreach (Revue revue in lesRevues)
            {
                if (revue.IdDoc == txbIdRevue.Text)
                {
                    trouve = true;
                    lblTitreRevue.Text = revue.Titre;
                    lesExemplairesParRevue = DAOPresse.getLesExemplairesByRevue(revue);
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

        #endregion

        private void btnValider_Click(object sender, EventArgs e)
        {
            int numParution;
            try
            {
                numParution = int.Parse(txbNumero.Text);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Numéro saisi non numérique");
                return;
            }

            Exemplaire exemplaireACreer = new Exemplaire(numParution, dtpParution.Value, txbImage.Text, "neuf");
            exemplaireACreer.Document = laRevue.getInstanceDocument();

            try
            {
                DAOPresse.creerExemplaire(exemplaireACreer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout en bdd - " + ex.Message);
                return;
            }
            MessageBox.Show("Ajout en bdd ok");
        }
    }
}
