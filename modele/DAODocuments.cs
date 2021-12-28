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
        private static readonly string connectionString = "server=localhost;user id=mediatek;password=q5OJ7QUAKHeBN3xe;database=mediatek86;SslMode=none";

        /// <summary>
        /// Retourne toutes les catégories à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Categorie</returns>
        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from public";

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Categorie categorie = new Categorie((string)curs.Field("id"),(string)curs.Field("libelle"));
                lesCategories.Add(categorie);
            }
            curs.Close();
            return lesCategories;
        }


        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public static List<Genre> getAllGenres()
        {
            List<Genre> lesGenres = new List<Genre>();
            string req = "Select * from genre order by libelle";

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Genre genre = new Genre((string)curs.Field("id"), (string)curs.Field("libelle"));
                lesGenres.Add(genre);
            }
            curs.Close();
            return lesGenres;
        }


        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public static List<Rayon> getAllRayons()
        {
            List<Rayon> lesRayons = new List<Rayon>();
            string req = "Select * from rayon order by libelle";

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Rayon rayon = new Rayon((string)curs.Field("id"), (string)curs.Field("libelle"));
                lesRayons.Add(rayon);
            }
            curs.Close();
            return lesRayons;
        }


        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public static List<Categorie> getAllPublics()
        {
            List<Categorie> lesPublics = new List<Categorie>();
            string req = "Select * from public";

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Categorie categorie = new Categorie((string)curs.Field("id"), (string)curs.Field("libelle"));
                lesPublics.Add(categorie);
            }
            curs.Close();
            return lesPublics;
        }


        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public static List<Livre> getAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection from livre l join document d on l.id=d.id";

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, null);


            while (curs.Read())
            {
                // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                Livre livre = new Livre((string)curs.Field("id"), (string)curs.Field("titre"), (string)curs.Field("ISBN"), (string)curs.Field("auteur"), (string)curs.Field("collection"), (string)curs.Field("image"));
                lesLivres.Add(livre);
            }
            curs.Close();

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

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                categorie = new Categorie((string)curs.Field("id"), (string)curs.Field("libelle"));
            }
            else
            {
                categorie = null;
            }
            curs.Close();
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

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                genre = new Genre((string)curs.Field("id"), (string)curs.Field("libelle"));
            }
            else
            {
               genre = null;
            }
            curs.Close();
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

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);


            if (curs.Read())
            {
                rayon = new Rayon((string)curs.Field("id"), (string)curs.Field("libelle"));
            }
            else
            {
                rayon = null;
            }
            curs.Close();
            return rayon;
        }
    }
}
