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

namespace Mediatek86
{
    public partial class frmMediatek : Form
    {
        static List<Categorie> lesCategories;
        static List<Domaine> lesDomaines;
        static List<Titre> lesTitres;

        static int afficheParutions;

        public frmMediatek()
        {
            InitializeComponent();
        }

        private void frmMediatek_Load(object sender, EventArgs e)
        {
            // Création de la connexion avec la base de données
            DAOFactory.creerConnection();

            // Chargement des objets en mémoire
            lesCategories = DAOCategorie.getAllCategories();
            lesDomaines = DAOPresse.getAllDomaines();
            lesTitres = DAOPresse.getAllTitre();

            // Affectation du Domaine à chaque Titre
            foreach (Titre titre in lesTitres)
            {
                Domaine domaine = DAOPresse.getDomainesByTitre(titre);
                titre.Domaine = domaine;   
            }
        }


        /*private void tabParutions_Click(object sender, EventArgs e)
        {

        }*/

        //-----------------------------------------------------------
        // ONGLET "PARUTIONS"
        //------------------------------------------------------------
        private void tabParutions_Enter(object sender, EventArgs e)
        {
            cbxTitres.DataSource = lesTitres;
            cbxTitres.DisplayMember = "nom";
        }

        private void cbxTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
                List<Parution> lesParutions;

                Titre titreSelectionne = (Titre)cbxTitres.SelectedItem;
                lesParutions = DAOPresse.getParutionByTitre(titreSelectionne);

                // ré-initialisation du dataGridView
                dgvParutions.Rows.Clear();

                // Parcours de la collection des titres et alimentation du datagridview
                foreach (Parution parution in lesParutions)
                {
                    dgvParutions.Rows.Add(parution.Numero, parution.DateParution, parution.Photo);
                }
            
        }

        //-----------------------------------------------------------
        // ONGLET "TITRES"
        //------------------------------------------------------------
        private void tabTitres_Enter(object sender, EventArgs e)
        {
            cbxDomaines.DataSource = lesDomaines;
            cbxDomaines.DisplayMember = "libelle";
        }

        private void cbxDomaines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Objet Domaine sélectionné dans la comboBox
            Domaine domaineSelectionne = (Domaine)cbxDomaines.SelectedItem;

            // ré-initialisation du dataGridView
            dgvTitres.Rows.Clear();

            // Parcours de la collection des titres et alimentation du datagridview
            foreach (Titre titre in lesTitres)
            {
                if (titre.Domaine.IdDomaine==domaineSelectionne.IdDomaine)
                {
                    dgvTitres.Rows.Add(titre.IdTitre, titre.Nom, titre.Empruntable);
                }
            }
        }

    }
}
