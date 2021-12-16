using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mediatek86.metier;

namespace Mediatek86.bdd
{
    class DAOPresse
    {

        public static Genre getGenreById(string pId)
        {
            Genre genre;
            string req = "Select * from genre where id = " + pId;

            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            if (reader.Read())
            {
                genre = new Genre(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
                genre =null;
            }
            DAOConnexion.deconnecter();
            return genre;
        }

        public static Genre getGenreByRevue(Revue pRevue)
        {
            Genre genre;
            //string req = "Select d.idDomaine,d.libelle from domaine d,titre t where d.idDomaine = t.idDomaine and t.idTitre='" ;
            string req = "Select g.id,g.libelle from genre g, document d where g.id = d.idgenre and d.id='";
            req += pRevue.IdDoc + "'";

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
        
        public static List<Revue> getAllRevues()
        {
            List<Revue> lesRevues = new List<Revue>();
            string req = "select r.id, titre, image, empruntable, periodicite, delaimiseadispo from revue r join document d on r.id = d.id";
            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            while (reader.Read())
            {
                // On ne renseigne pas le domaine car on ne put pas ouvrir 2 dataReader dans la même connexion
                //Domaine domaine = getDomainesById(reader[3].ToString());
                Revue revue = new Revue(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), char.Parse(reader[3].ToString()), reader[4].ToString(), int.Parse(reader[5].ToString()));
                lesRevues.Add(revue);
            }
            DAOConnexion.deconnecter();

            return lesRevues;
        }
        
        /*public static List<Exemplaire> getParutionByTitre(Revue pTitre)
        {
            List<Exemplaire> lesParutions = new List<Exemplaire>();
            string req = "Select * from parution where idTitre = " + pTitre.IdTitre;

            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            while (reader.Read())
            {
                Exemplaire parution = new Exemplaire(int.Parse(reader[1].ToString()), DateTime.Parse(reader[2].ToString()),pTitre,reader[3].ToString());
                lesParutions.Add(parution);
            }
            DAOConnexion.deconnecter();
            return lesParutions;
        }*/


        // Crée dans la BDD l'objet CompteBancaire passé en paramètre
        /*public static void creerCompte(CompteBancaire unCompte)
        {
            string requete = "insert into compte_GRE values('" + unCompte.NumCompte + "','" +
                unCompte.NomTitulaire + "','" + unCompte.SoldeCompte.ToString() + "')";
            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }*/

        // Modifie dans la BDD le solde de l'objet CompteBancaire passé en paramètre
        /*public static void modifierCompte(CompteBancaire unCompte)
        {
            string requete = "update compte_GRE set solde=" + unCompte.SoldeCompte + " where numero='" + unCompte.NumCompte + "'";

            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }*/
    }
}

