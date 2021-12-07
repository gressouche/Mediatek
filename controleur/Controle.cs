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
        /// Récupère et retourne les infos des domaines provenant de la BDD
        /// </summary>
        /// <returns>liste des domaines</returns>
        public List<Domaine> GetLesDomaines()
        {
            return DAOPresse.getAllDomaines();
        }


        /// <summary>
        /// Récupère tous les titres de presse
        /// </summary>
        /// <returns>liste des titres</returns>
        public List<Titre> GetLesTitres()
        {
            return DAOPresse.getAllTitres();
        }


        /// <summary>
        /// Récupère le domaine lié au titre passé en paramètre
        /// </summary>
        /// <param name="unTitre">Objet Titre dont on veut obtenir l'objet Domaine associé</param>
        /// <returns>le Domaine associé au Titre</returns>
        public Domaine GetDomaineByTitre(Titre unTitre)
        {
            return DAOPresse.getDomainesByTitre(unTitre);
        }


        /// <summary>
        /// Récupère toutes les parutions d'un titre de presse
        /// </summary>
        /// <param name="unTitre">Objet Titre dont on veut obtenir les parutions</param>
        /// <returns>Liste de Parutions</returns>
        public List<Parution> getParutionByTitre(Titre unTitre)
        {
            return DAOPresse.getParutionByTitre(unTitre);
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
        

        /*      /// <summary>
              /// Demande de suppression d'un développeur
              /// </summary>
              /// <param name="developpeur">objet developpeur à supprimer</param>
              public void DelDeveloppeur(Developpeur developpeur)
              {
                  AccesDonnees.DelDepveloppeur(developpeur);
              }

              /// <summary>
              /// Demande d'ajout d'un développeur
              /// </summary>
              /// <param name="developpeur"></param>
              public void AddDeveloppeur(Developpeur developpeur)
              {
                  AccesDonnees.AddDeveloppeur(developpeur);
              }

              /// <summary>
              /// Demande de modification d'un développeur
              /// </summary>
              /// <param name="developpeur"></param>
              public void UpdateDeveloppeur(Developpeur developpeur)
              {
                  AccesDonnees.UpdateDeveloppeur(developpeur);
              }

              /// <summary>
              /// Demande de changement de pwd
              /// </summary>
              /// <param name="developpeur"></param>
              public void UpdatePwd(Developpeur developpeur)
              {
                  AccesDonnees.UpdatePwd(developpeur);
              }
        */
    }

}

