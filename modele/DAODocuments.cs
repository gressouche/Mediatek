using Mediatek86.metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.bdd
{
    class DAODocuments
    {
        /// <summary>
        /// Retourne toutes les catégories à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Categorie</returns>
        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from public";

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, null);
 
            while (DAOConnexion.Read())
            {
                Categorie categorie = new Categorie((string)DAOConnexion.Field("id"),(string)DAOConnexion.Field("libelle"));
                lesCategories.Add(categorie);
            }
            DAOConnexion.deconnecter();
            return lesCategories;
        }


        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public static List<Genre> getAllGenres()
        {
            List<Genre> lesGenres = new List<Genre>();
            string req = "Select * from genre";

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, null);

            while (DAOConnexion.Read())
            {
                Genre genre = new Genre((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("libelle"));
                lesGenres.Add(genre);
            }
            DAOConnexion.deconnecter();
            return lesGenres;
        }

        
        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public static List<Livre> getAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection from livre l join document d on l.id=d.id";

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, null);

            while (DAOConnexion.Read())
            {
                // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                Livre livre = new Livre((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("titre"), (string)DAOConnexion.Field("ISBN"), (string)DAOConnexion.Field("auteur"), (string)DAOConnexion.Field("collection"), (string)DAOConnexion.Field("image"));
                lesLivres.Add(livre);
            }
            DAOConnexion.deconnecter();

            return lesLivres;
        }

        /// <summary>
        /// Retourne la catégorie associée à un livre
        /// </summary>
        /// <param name="pLivre">Objet Livre</param>
        /// <returns>Objet Catégorie associé au Livre</returns>
        public static Categorie getCategorieByLivre(Livre pLivre)
        {
            Categorie categorie;
            string req = "Select p.id,p.libelle from public p,document d where p.id = d.idPublic and d.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pLivre.IdDoc }
            };

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, parameters);

            if (DAOConnexion.Read())
            {
                categorie = new Categorie((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("libelle"));
            }
            else
            {
                categorie = null;
            }
            DAOConnexion.deconnecter();
            return categorie;
        }


        /// <summary>
        /// Retourne le genre associée à un livre
        /// </summary>
        /// <param name="pLivre"></param>
        /// <returns>Objet Genre associé au Livre</returns>
        public static Genre getGenreByLivre(Livre pLivre)
        {
            Genre genre;
            string req = "Select g.id,g.libelle from genre g,document d where g.id = d.idGenre and d.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pLivre.IdDoc }
            };

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, parameters);

            if (DAOConnexion.Read())
            {
                genre = new Genre((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("libelle"));
            }
            else
            {
               genre = null;
            }
            DAOConnexion.deconnecter();
            return genre;
        }
    }
}
