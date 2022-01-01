using System.Collections.Generic;
using Mediatek86.bdd;
using Mediatek86.metier;


namespace Mediatek86.controleur
{
    internal class Controle
    {

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            FrmMediatek frmMediatek = new FrmMediatek(this);
            frmMediatek.ShowDialog();
        }


        /// <summary>
        /// Récupère tous les titres de presse
        /// </summary>
        /// <returns>liste des titres</returns>
        public List<Revue> getLesRevues()
        {
            return DaoPresse.getLesRevues();
        }


        /// <summary>
        /// Récupère le domaine lié au titre passé en paramètre
        /// </summary>
        /// <param name="unTitre">Objet Titre dont on veut obtenir l'objet Domaine associé</param>
        /// <returns>le Domaine associé au Titre</returns>
        public Genre getGenreByRevue(Revue uneRevue)
        {
            return DaoPresse.getGenreByRevue(uneRevue);
        }


        /// <summary>
        /// Récupère toutes les catégories de public de la bdd
        /// </summary>
        /// <returns>Collection des objets Categorie</returns>
        public List<Categorie> getAllCategories()
        {
            return DaoDocuments.getAllCategories();
        }


        /// <summary>
        /// Récupère tous les genres de documents depuis la bdd
        /// </summary>
        /// <returns>Collection d'objets Genre</returns>
        public List<Genre> getAllGenres()
        {
            return DaoDocuments.getAllGenres();
        }


        /// <summary>
        /// Récupère tous les livres de la bdd
        /// </summary>
        /// <returns>Collection d'objets Livre</returns>
        public List<Livre> getAllLivres()
        {
            return DaoDocuments.getAllLivres();
        }


        /// <summary>
        /// Récupère tous les rayons de la bdd
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public List<Rayon> getAllRayons()
        {
            return DaoDocuments.getAllRayons();
        }


        /// <summary>
        /// Récupère toutes les catégories de public de la bdd
        /// </summary>
        /// <returns>Collection d'objets Categorie</returns>
        public List<Categorie> getAllPublics()
        {
            return DaoDocuments.getAllPublics();
        }


        /// <summary>
        /// Récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="revue">L'objet Revue concerné</param>
        /// <returns>Collection d'objets Exemplaire</returns>
        public List<Exemplaire> getLesExemplairesByRevue(Revue revue)
        {
            return DaoPresse.getLesExemplairesByRevue(revue);
        }


        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        public void creerExemplaire(Exemplaire exemplaire)
        {
            DaoPresse.creerExemplaire(exemplaire);
        }


        /// <summary>
        /// Récupère le genre associé à un livre
        /// </summary>
        /// <param name="livre">L'objet Livre concerné</param>
        /// <returns>L'objet Genre associé à ce Livre</returns>
        public Genre getGenreByLivre(Livre livre)
        {
            return DaoDocuments.getGenreByLivre(livre);

        }


        /// <summary>
        /// Récupère le rayon où est entreposé un livre
        /// </summary>
        /// <param name="livre">L'objet Livre concerné</param>
        /// <returns>L'objet Rayon associé à ce Livre</returns>
        public Rayon getRayonByLivre(Livre livre)
        {
            return DaoDocuments.getRayonByLivre(livre);
        }


        /// <summary>
        /// Récupère la catégorie de public concerné par un livre
        /// </summary>
        /// <param name="livre">L'objet Livre concerné</param>
        /// <returns>L'objet Categorie associé</returns>
        public Categorie getCategorieByLivre(Livre livre)
        {
            return DaoDocuments.getCategorieByLivre(livre);
        }

    }

}

