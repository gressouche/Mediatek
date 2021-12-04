using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mediatek86.metier;

namespace Mediatek86.bdd
{
    class DAOCategorie
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
