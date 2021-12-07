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

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            while (reader.Read())
            {
                Categorie categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
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

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            while (reader.Read())
            {
                Genre genre = new Genre(reader[0].ToString(), reader[1].ToString());
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
            string req = "Select l.idDoc, l.ISBN, l.auteur, d.titre, d.image, l.collection from livre l join document d on l.idDoc=d.idDoc";

            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            while (reader.Read())
            {
                // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                Livre livre = new Livre(reader[0].ToString(), reader[3].ToString(), reader[1].ToString(),
                    reader[2].ToString(), reader[5].ToString(), reader[4].ToString());
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
            string req = "Select p.idP,p.libelle from public p,document d where p.idP = d.idP and d.idDoc='";
            req += pLivre.IdDoc + "'";

            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            if (reader.Read())
            {
                categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
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
            string req = "Select g.idG,g.libelle from genre g,document d where g.idG = d.idG and d.idDoc='";
            req += pLivre.IdDoc + "'";

            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            if (reader.Read())
            {
                genre = new Genre(reader[0].ToString(), reader[1].ToString());
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
