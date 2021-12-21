using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.bdd;
using Mediatek86.metier;


namespace Mediatek86.controleur
{
    internal class Controle
    {

        /// <summary>
        /// fenêtre d'authentification
        /// </summary>
        private readonly FrmMediatek frmMediatek;


        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmMediatek = new FrmMediatek(this);
            frmMediatek.ShowDialog();
        }


        /// <summary>
        /// Création de la connection à la base de données
        /// </summary>
        public void creerConnectionBDD()
        {
            DAOConnexion.creerConnection();
        }


        /// <summary>
        /// Récupère tous les titres de presse
        /// </summary>
        /// <returns>liste des titres</returns>
        public List<Revue> GetLesRevues()
        {
            return DAOPresse.getLesRevues();
        }


        /// <summary>
        /// Récupère le domaine lié au titre passé en paramètre
        /// </summary>
        /// <param name="unTitre">Objet Titre dont on veut obtenir l'objet Domaine associé</param>
        /// <returns>le Domaine associé au Titre</returns>
        public Genre GetGenreByRevue(Revue uneRevue)
        {
            return DAOPresse.getGenreByRevue(uneRevue);
        }


        public List<Categorie> getAllCategories()
        {
            return DAODocuments.getAllCategories();
        }


        public List<Genre> getAllGenres()
        {
            return DAODocuments.getAllGenres();
        }


        public List<Livre> getAlllivres()
        {
            return DAODocuments.getAllLivres();
        }
        

    }

}

