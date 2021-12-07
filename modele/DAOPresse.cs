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
        public static List<Domaine> getAllDomaines()
        {
            List<Domaine> lesDomaines = new List<Domaine>();
            string req = "Select * from domaine";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Domaine domaine = new Domaine(reader[0].ToString(), reader[1].ToString());
                lesDomaines.Add(domaine);
            }
            DAOFactory.deconnecter();
            return lesDomaines;
        }

        public static Domaine getDomainesById(string pId)
        {
            Domaine domaine;
            string req = "Select * from domaine where idDomaine = " + pId;

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                domaine = new Domaine(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
                domaine =null;
            }
            DAOFactory.deconnecter();
            return domaine;
        }

        public static Domaine getDomainesByTitre(Titre pTitre)
        {
            Domaine domaine;
            string req = "Select d.idDomaine,d.libelle from domaine d,titre t where d.idDomaine = t.idDomaine and t.idTitre='" ;
            req += pTitre.IdTitre + "'";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                domaine = new Domaine(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
                domaine = null;
            }
            DAOFactory.deconnecter();
            return domaine;
        }
        public static List<Titre> getAllTitre()
        {
            List<Titre> lesTitres = new List<Titre>();
            string req = "Select * from titre";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                // On ne renseigne pas le domaine car on ne put pas ouvrir 2 dataReader dans la même connexion
                //Domaine domaine = getDomainesById(reader[3].ToString());
                //Titre titre = new Titre(reader[0].ToString(), reader[1].ToString(),char.Parse(reader[2].ToString()),domaine);
                Titre titre = new Titre(reader[0].ToString(), reader[1].ToString(), char.Parse(reader[2].ToString()));
                lesTitres.Add(titre);
            }
            DAOFactory.deconnecter();

            return lesTitres;
        }
        
        public static List<Parution> getParutionByTitre(Titre pTitre)
        {
            List<Parution> lesParutions = new List<Parution>();
            string req = "Select * from parution where idTitre = " + pTitre.IdTitre;

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Parution parution = new Parution(int.Parse(reader[1].ToString()), DateTime.Parse(reader[2].ToString()),pTitre,reader[3].ToString());
                lesParutions.Add(parution);
            }
            DAOFactory.deconnecter();
            return lesParutions;
        }


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

