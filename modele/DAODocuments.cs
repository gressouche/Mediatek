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

        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from public";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Categorie categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
                lesCategories.Add(categorie);
            }
            DAOFactory.deconnecter();
            return lesCategories;
        }

        public static List<Genre> getAllGenres()
        {
            List<Genre> lesGenres = new List<Genre>();
            string req = "Select * from genre";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Genre genre = new Genre(reader[0].ToString(), reader[1].ToString());
                lesGenres.Add(genre);
            }
            DAOFactory.deconnecter();
            return lesGenres;
        }
        
        public static List<Livre> getAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.idDoc, l.ISBN, l.auteur, d.titre, d.image, l.collection from livre l join document d on l.idDoc=d.idDoc";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                // On ne renseigne pas le genre et la catégorie car on ne peut pas ouvrir 2 dataReader dans la même connexion
                Livre livre = new Livre(reader[0].ToString(), reader[3].ToString(), reader[1].ToString(),
                    reader[2].ToString(), reader[5].ToString(), reader[4].ToString());
                lesLivres.Add(livre);
            }
            DAOFactory.deconnecter();

            return lesLivres;
        }

        public static Categorie getCategorieByLivre(Livre pLivre)
        {
            Categorie categorie;
            string req = "Select p.idP,p.libelle from public p,document d where p.idP = d.idP and d.idDoc='";
            req += pLivre.IdDoc + "'";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
                categorie = null;
            }
            DAOFactory.deconnecter();
            return categorie;
        }

        public static Genre getGenreByLivre(Livre pLivre)
        {
            Genre genre;
            string req = "Select g.idG,g.libelle from genre g,document d where g.idG = d.idG and d.idDoc='";
            req += pLivre.IdDoc + "'";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                genre = new Genre(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
               genre = null;
            }
            DAOFactory.deconnecter();
            return genre;
        }
    }
}
