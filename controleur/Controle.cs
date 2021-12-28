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
        /// Récupère tous les titres de presse
        /// </summary>
        /// <returns>liste des titres</returns>
        public List<Revue> GetLesRevues()
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


        public List<Categorie> getAllCategories()
        {
            return DaoDocuments.getAllCategories();
        }


        public List<Genre> getAllGenres()
        {
            return DaoDocuments.getAllGenres();
        }


        public List<Livre> getAllLivres()
        {
            return DaoDocuments.getAllLivres();
        }


        public List<Rayon> getAllRayons()
        {
            return DaoDocuments.getAllRayons();
        }


        public List<Categorie> getAllPublics()
        {
            return DaoDocuments.getAllPublics();
        }

        public List<Exemplaire> getLesExemplairesByRevue(Revue revue)
        {
            return DaoPresse.getLesExemplairesByRevue(revue);
        }


        public void creerExemplaire(Exemplaire exemplaire)
        {
            DaoPresse.creerExemplaire(exemplaire);
        }

        public Genre getGenreByLivre(Livre livre)
        {
            return DaoDocuments.getGenreByLivre(livre);

        }

        public Rayon getRayonByLivre(Livre livre)
        {
            return DaoDocuments.getRayonByLivre(livre);
        }

    }

}

