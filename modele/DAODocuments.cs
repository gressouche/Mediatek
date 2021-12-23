using Mediatek86.metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.bdd
{
    static class DaoDocuments
    {
        /// <summary>
        /// Retourne toutes les catégories à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Categorie</returns>
        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from public";

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, null);
 
            while (DaoConnexion.Read())
            {
                Categorie categorie = new Categorie((string)DaoConnexion.Field("id"),(string)DaoConnexion.Field("libelle"));
                lesCategories.Add(categorie);
            }
            DaoConnexion.deconnecter();
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

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, null);

            while (DaoConnexion.Read())
            {
                Genre genre = new Genre((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
                lesGenres.Add(genre);
            }
            DaoConnexion.deconnecter();
            return lesGenres;
        }


        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public static List<Rayon> getAllRayons()
        {
            List<Rayon> lesRayons = new List<Rayon>();
            string req = "Select * from rayon";

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, null);

            while (DaoConnexion.Read())
            {
                Rayon rayon = new Rayon((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
                lesRayons.Add(rayon);
            }
            DaoConnexion.deconnecter();
            return lesRayons;
        }


        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public static List<Livre> getAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection from livre l join document d on l.id=d.id";

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, null);

            while (DaoConnexion.Read())
            {
                // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                Livre livre = new Livre((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("titre"), (string)DaoConnexion.Field("ISBN"), (string)DaoConnexion.Field("auteur"), (string)DaoConnexion.Field("collection"), (string)DaoConnexion.Field("image"));
                lesLivres.Add(livre);
            }
            DaoConnexion.deconnecter();

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

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, parameters);

            if (DaoConnexion.Read())
            {
                categorie = new Categorie((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
            }
            else
            {
                categorie = null;
            }
            DaoConnexion.deconnecter();
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

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, parameters);

            if (DaoConnexion.Read())
            {
                genre = new Genre((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
            }
            else
            {
               genre = null;
            }
            DaoConnexion.deconnecter();
            return genre;
        }


        /// <summary>
        /// Recherche le rayon où est stocké le livre
        /// </summary>
        /// <param name="pLivre"></param>
        /// <returns>Objet Rayon associé au Livre</returns>
        public static Rayon getRayonByLivre(Livre pLivre)
        {
           Rayon rayon;
            string req = "Select r.id,r.libelle from rayon r,document d where r.id = d.idRayon and d.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pLivre.IdDoc }
            };

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, parameters);

            if (DaoConnexion.Read())
            {
                rayon = new Rayon((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
            }
            else
            {
                rayon = null;
            }
            DaoConnexion.deconnecter();
            return rayon;
        }
    }
}
