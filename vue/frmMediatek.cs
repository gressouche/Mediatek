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
        static List<Domaine> lesDomaines;
        static List<Titre> lesTitres;
        static List<Livre> lesLivres;

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
            //lesDomaines = DAOPresse.getAllDomaines();
            // je passe par le contrôleur
            lesDomaines = controle.GetLesDomaines();
            lesTitres = controle.GetLesTitres();

            // Affectation du Domaine à chaque Titre
            foreach (Titre titre in lesTitres)
            {
                Domaine domaine = DAOPresse.getDomainesByTitre(titre);
                titre.Domaine = domaine;
            }
        }

        #endregion


        #region Parutions
        //-----------------------------------------------------------
        // ONGLET "PARUTIONS"
        //------------------------------------------------------------
        private void tabParutions_Enter(object sender, EventArgs e)
        {
            // Chargement de la liste déroulante depuis la collection des Titres
            cbxTitres.DataSource = lesTitres;
            cbxTitres.DisplayMember = "nom";
        }


        /// <summary>
        /// Sélection d'un titre dans la liste déroulante : on recherche toutes les parutions
        /// du titre sélectionné, et on les charge dans le datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Parution> lesParutions;

            Titre titreSelectionne = (Titre)cbxTitres.SelectedItem;
            lesParutions = controle.getParutionByTitre(titreSelectionne);

            // ré-initialisation du dataGridView
            dgvParutions.Rows.Clear();

            // Parcours de la collection des titres et alimentation du datagridview
            foreach (Parution parution in lesParutions)
            {
                dgvParutions.Rows.Add(parution.Numero, parution.DateParution, parution.Photo);
            }

        }
        #endregion


        #region Titres
        //-----------------------------------------------------------
        // ONGLET "TITRES"
        //------------------------------------------------------------
        private void tabTitres_Enter(object sender, EventArgs e)
        {
            // Chargement de la liste déroulante à partir de la collection des Domaines
            cbxDomaines.DataSource = lesDomaines;
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
            // Objet Domaine sélectionné dans la comboBox
            Domaine domaineSelectionne = (Domaine)cbxDomaines.SelectedItem;

            // ré-initialisation du dataGridView
            dgvTitres.Rows.Clear();

            // Parcours de la collection des titres et alimentation du datagridview
            foreach (Titre titre in lesTitres)
            {
                if (titre.Domaine.IdDomaine == domaineSelectionne.IdDomaine)
                {
                    dgvTitres.Rows.Add(titre.IdTitre, titre.Nom, titre.Empruntable);
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

            // Affectation de la catégorie de public à chaque Livre
            foreach (Livre livre in lesLivres)
            {
                Categorie categorie = DAODocuments.getCategorieByLivre(livre);
                livre.LaCategorie = categorie;
            }

            // Affectation du genre à chaque Livre
            foreach (Livre livre in lesLivres)
            {
                Genre genre = DAODocuments.getGenreByLivre(livre);
                livre.LeGenre = genre;
            }
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
                    lblISBN.Text = livre.ISBN1;
                    lblImage.Text = livre.Image;
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
                    dgvLivres.Rows.Add(livre.IdDoc, livre.Titre, livre.Auteur, livre.ISBN1, livre.LaCollection);
                }
            }
        }
        #endregion

    }
}
